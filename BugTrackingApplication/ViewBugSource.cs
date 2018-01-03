using System;
using System.Collections.Generic;

using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SharpBucket.V2.Pocos;
using RestSharp;
using System.Net;
using ScintillaNET;
using Style = ScintillaNET.Style;
using System.IO;


namespace BugTrackingApplication
{
    /// <summary>
    /// class representing tthe view source form, allows editing of source
    /// </summary>
    public partial class ViewBugSource : Form
    {
        private Project project;
        private Bug bug;
        private string revision;
        private User user;
        private MainWindow mainWindow;
        private string src;
        private string tempPath;
        private string fileName;
        private Scintilla TextArea;


        /// <summary>
        /// Constructor which gets revision it is not provided and then gets the source of the given location.
        /// </summary>
        /// <param name="project">The project that the bug is a part of</param>
        /// <param name="bug">The bug which is having it's source loaded</param>
        /// <param name="user">The current authenticated iser</param>
        public ViewBugSource(Project project, Bug bug, User user, MainWindow mainWindow)
        {
            InitializeComponent();
            Console.WriteLine("THis should be loading now");
            this.project = project;
            this.bug = bug;
            this.user = user;
            this.mainWindow = mainWindow;
            //if the bug revision is unknown
            if (bug.Revision.Equals("UNKNOWN"))
            {
                //we need  to get the latest revision
                List<Commit> commits = user.V2Api.RepositoriesEndPoint().RepositoryResource(project.ProjectOwner, project.ProjectName).ListCommits();
                //we just need to first one
                Commit c = commits.ElementAt<Commit>(0);
                revision = c.hash;
                
            }
            //we need to craft the rest request
            RestRequest request = new RestRequest("/2.0/repositories/{username}/{repo_slug}/src/{node}/{path}", Method.GET);
            //Console.WriteLine(revision);

            //these replace what are in brackets
            request.AddUrlSegment("username", project.ProjectOwner);
            request.AddUrlSegment("repo_slug", project.ProjectName);
            request.AddUrlSegment("node", revision);
            request.AddUrlSegment("path", bug.ClassName);
            

           


            IRestResponse r = user.Client.Execute(request);
            //if we get 404 that means there isnt the file so its the wrong location.
            if (r.StatusCode.Equals(HttpStatusCode.NotFound))
            {
                mainWindow.ValidSource = false;
                MessageBox.Show("File Path not found in repository please check that it is correct and ammend in bug information", "Error: Location Not Found", MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                mainWindow.ValidSource = true;
                src = r.Content;
                //we then need to create a file
                //if we have file path we need  to create file in temp folder
                tempPath = Path.GetTempPath();
                Console.WriteLine(tempPath);
                string dir = bug.ClassName.Split('/')[0];
                string tempDirectory = tempPath+dir;
                tempPath = tempPath + bug.ClassName;
                fileName = bug.ClassName.Split('/')[1];

                if (!Directory.Exists(tempDirectory))
                {
                    Directory.CreateDirectory(tempDirectory);
                }
                File.WriteAllText(tempPath, src);
                
            }
            
        }

        private void commitFileToRepositoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
            //then open message form
            CommitMessage cm = new CommitMessage(this);
            cm.Show();
                       

           

        }

        /// <summary>
        /// Function used to commit a file
        /// </summary>
        /// <param name="message">The commit message</param>
        public void CommitFile(string message)
        {
            RestRequest request = new RestRequest("/2.0/repositories/{username}/{repo_slug}/src/", Method.POST);

            request.AddUrlSegment("username", project.ProjectOwner);
            request.AddUrlSegment("repo_slug", project.ProjectName);

            string uploadPath = bug.ClassName.Split('/')[0] + "\\" + fileName;
            Console.WriteLine(uploadPath);
            request.AddFile(bug.ClassName, tempPath);
            request.AddParameter("message", message);
            IRestResponse response = user.Client.Execute(request);

            Console.WriteLine(response.StatusCode);
            Console.WriteLine("Done");

            MessageBox.Show("File has been Uploaded to Version Control", "Version Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveFile()
        {
            string dir = bug.ClassName.Split('/')[0];
            string tempDirectory = tempPath + dir;


            if (!Directory.Exists(tempDirectory))
            {
                Directory.CreateDirectory(tempDirectory);
            }
            File.WriteAllText(tempPath, TextArea.Text);
        }

        /// <summary>
        /// called on closing of form to try and free up memeory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewBugSource_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// Function called when the save file locally button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileLocallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = bug.ClassName.Split('/')[0];
            string tempDirectory = tempPath + dir;


            if (!Directory.Exists(tempDirectory))
            {
                Directory.CreateDirectory(tempDirectory);
            }
            File.WriteAllText(tempPath, TextArea.Text);
            MessageBox.Show("File has been saved locally", "File Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        

        /// <summary>
        /// Function called when form loads
        /// Used By the Scintilla wrapper
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewBugSource_Load(object sender, EventArgs e)
        {

            // CREATE CONTROL
            TextArea = new ScintillaNET.Scintilla();
            TextPanel.Controls.Add(TextArea);

            // BASIC CONFIG
            TextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            TextArea.TextChanged += (this.OnTextChanged);

            // INITIAL VIEW CONFIG
            TextArea.WrapMode = WrapMode.None;
            TextArea.IndentationGuides = IndentView.LookBoth;

            // STYLING
            InitColors();
            InitSyntaxColoring();

            // NUMBER MARGIN
            InitNumberMargin();

            // BOOKMARK MARGIN
            InitBookmarkMargin();

            // CODE FOLDING MARGIN
            InitCodeFolding();

           

            
            LoadDataFromFile(tempPath);

         

        }

        private void InitColors()
        {

            TextArea.SetSelectionBackColor(true, IntToColor(0x114D9C));

        }


        private void InitSyntaxColoring()
        {

            // Configure the default style
            TextArea.StyleResetDefault();
            TextArea.Styles[Style.Default].Font = "Consolas";
            TextArea.Styles[Style.Default].Size = 10;
            TextArea.Styles[Style.Default].BackColor = IntToColor(0x212121);
            TextArea.Styles[Style.Default].ForeColor = IntToColor(0xFFFFFF);
            TextArea.StyleClearAll();

            // Configure the CPP (C#) lexer styles
            TextArea.Styles[Style.Cpp.Identifier].ForeColor = IntToColor(0xD0DAE2);
            TextArea.Styles[Style.Cpp.Comment].ForeColor = IntToColor(0xBD758B);
            TextArea.Styles[Style.Cpp.CommentLine].ForeColor = IntToColor(0x40BF57);
            TextArea.Styles[Style.Cpp.CommentDoc].ForeColor = IntToColor(0x2FAE35);
            TextArea.Styles[Style.Cpp.Number].ForeColor = IntToColor(0xFFFF00);
            TextArea.Styles[Style.Cpp.String].ForeColor = IntToColor(0xFFFF00);
            TextArea.Styles[Style.Cpp.Character].ForeColor = IntToColor(0xE95454);
            TextArea.Styles[Style.Cpp.Preprocessor].ForeColor = IntToColor(0x8AAFEE);
            TextArea.Styles[Style.Cpp.Operator].ForeColor = IntToColor(0xE0E0E0);
            TextArea.Styles[Style.Cpp.Regex].ForeColor = IntToColor(0xff00ff);
            TextArea.Styles[Style.Cpp.CommentLineDoc].ForeColor = IntToColor(0x77A7DB);
            TextArea.Styles[Style.Cpp.Word].ForeColor = IntToColor(0x48A8EE);
            TextArea.Styles[Style.Cpp.Word2].ForeColor = IntToColor(0xF98906);
            TextArea.Styles[Style.Cpp.CommentDocKeyword].ForeColor = IntToColor(0xB3D991);
            TextArea.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = IntToColor(0xFF0000);
            TextArea.Styles[Style.Cpp.GlobalClass].ForeColor = IntToColor(0x48A8EE);

            TextArea.Lexer = Lexer.Cpp;

            TextArea.SetKeywords(0, "class extends implements import interface new case do while else if for in switch throw get set function var try catch finally while with default break continue delete return each const namespace package include use is as instanceof typeof author copy default deprecated eventType example exampleText exception haxe inheritDoc internal link mtasc mxmlc param private return see serial serialData serialField since throws usage version langversion playerversion productversion dynamic private public partial static intrinsic internal native override protected AS3 final super this arguments null Infinity NaN undefined true false abstract as base bool break by byte case catch char checked class const continue decimal default delegate do double descending explicit event extern else enum false finally fixed float for foreach from goto group if implicit in int interface internal into is lock long new null namespace object operator out override orderby params private protected public readonly ref return switch struct sbyte sealed short sizeof stackalloc static string select this throw true try typeof uint ulong unchecked unsafe ushort using var virtual volatile void while where yield");
            TextArea.SetKeywords(1, "void Null ArgumentError arguments Array Boolean Class Date DefinitionError Error EvalError Function int Math Namespace Number Object RangeError ReferenceError RegExp SecurityError String SyntaxError TypeError uint XML XMLList Boolean Byte Char DateTime Decimal Double Int16 Int32 Int64 IntPtr SByte Single UInt16 UInt32 UInt64 UIntPtr Void Path File System Windows Forms ScintillaNET");

        }

        private void OnTextChanged(object sender, EventArgs e)
        {

        }


        #region Numbers, Bookmarks, Code Folding

        /// <summary>
        /// the background color of the text area
        /// </summary>
        private const int BACK_COLOR = 0x2A211C;

        /// <summary>
        /// default text color of the text area
        /// </summary>
        private const int FORE_COLOR = 0xB7B7B7;

        /// <summary>
        /// change this to whatever margin you want the line numbers to show in
        /// </summary>
        private const int NUMBER_MARGIN = 1;

        /// <summary>
        /// change this to whatever margin you want the bookmarks/breakpoints to show in
        /// </summary>
        private const int BOOKMARK_MARGIN = 2;
        private const int BOOKMARK_MARKER = 2;

        /// <summary>
        /// change this to whatever margin you want the code folding tree (+/-) to show in
        /// </summary>
        private const int FOLDING_MARGIN = 3;

        /// <summary>
        /// set this true to show circular buttons for code folding (the [+] and [-] buttons on the margin)
        /// </summary>
        private const bool CODEFOLDING_CIRCULAR = true;

        private void InitNumberMargin()
        {

            TextArea.Styles[Style.LineNumber].BackColor = IntToColor(BACK_COLOR);
            TextArea.Styles[Style.LineNumber].ForeColor = IntToColor(FORE_COLOR);
            TextArea.Styles[Style.IndentGuide].ForeColor = IntToColor(FORE_COLOR);
            TextArea.Styles[Style.IndentGuide].BackColor = IntToColor(BACK_COLOR);

            var nums = TextArea.Margins[NUMBER_MARGIN];
            nums.Width = 30;
            nums.Type = MarginType.Number;
            nums.Sensitive = true;
            nums.Mask = 0;

            TextArea.MarginClick += TextArea_MarginClick;
        }

        private void InitBookmarkMargin()
        {

            //TextArea.SetFoldMarginColor(true, IntToColor(BACK_COLOR));

            var margin = TextArea.Margins[BOOKMARK_MARGIN];
            margin.Width = 20;
            margin.Sensitive = true;
            margin.Type = MarginType.Symbol;
            margin.Mask = (1 << BOOKMARK_MARKER);
            //margin.Cursor = MarginCursor.Arrow;

            var marker = TextArea.Markers[BOOKMARK_MARKER];
            marker.Symbol = MarkerSymbol.Circle;
            marker.SetBackColor(IntToColor(0xFF003B));
            marker.SetForeColor(IntToColor(0x000000));
            marker.SetAlpha(100);

        }

        private void InitCodeFolding()
        {

            TextArea.SetFoldMarginColor(true, IntToColor(BACK_COLOR));
            TextArea.SetFoldMarginHighlightColor(true, IntToColor(BACK_COLOR));

            // Enable code folding
            TextArea.SetProperty("fold", "1");
            TextArea.SetProperty("fold.compact", "1");

            // Configure a margin to display folding symbols
            TextArea.Margins[FOLDING_MARGIN].Type = MarginType.Symbol;
            TextArea.Margins[FOLDING_MARGIN].Mask = Marker.MaskFolders;
            TextArea.Margins[FOLDING_MARGIN].Sensitive = true;
            TextArea.Margins[FOLDING_MARGIN].Width = 20;

            // Set colors for all folding markers
            for (int i = 25; i <= 31; i++)
            {
                TextArea.Markers[i].SetForeColor(IntToColor(BACK_COLOR)); // styles for [+] and [-]
                TextArea.Markers[i].SetBackColor(IntToColor(FORE_COLOR)); // styles for [+] and [-]
            }

            // Configure folding markers with respective symbols
            TextArea.Markers[Marker.Folder].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CirclePlus : MarkerSymbol.BoxPlus;
            TextArea.Markers[Marker.FolderOpen].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CircleMinus : MarkerSymbol.BoxMinus;
            TextArea.Markers[Marker.FolderEnd].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CirclePlusConnected : MarkerSymbol.BoxPlusConnected;
            TextArea.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            TextArea.Markers[Marker.FolderOpenMid].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CircleMinusConnected : MarkerSymbol.BoxMinusConnected;
            TextArea.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            TextArea.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            TextArea.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);

        }

        private void TextArea_MarginClick(object sender, MarginClickEventArgs e)
        {
            if (e.Margin == BOOKMARK_MARGIN)
            {
                // Do we have a marker for this line?
                const uint mask = (1 << BOOKMARK_MARKER);
                var line = TextArea.Lines[TextArea.LineFromPosition(e.Position)];
                if ((line.MarkerGet() & mask) > 0)
                {
                    // Remove existing bookmark
                    line.MarkerDelete(BOOKMARK_MARKER);
                }
                else
                {
                    // Add bookmark
                    line.MarkerAdd(BOOKMARK_MARKER);
                }
            }
        }

        #endregion


        private void LoadDataFromFile(string path)
        {
            if (File.Exists(path))
            {
                FileName.Text = Path.GetFileName(path);
                methodBlock.Text = bug.Method;
                lineNumber.Text = bug.LineNum;
                lineNumEnd.Text = bug.LineNumEnd;
                TextArea.Text = File.ReadAllText(path);
            }
        }


        #region Uppercase / Lowercase

        private void Lowercase()
        {

            // save the selection
            int start = TextArea.SelectionStart;
            int end = TextArea.SelectionEnd;

            // modify the selected text
            TextArea.ReplaceSelection(TextArea.GetTextRange(start, end - start).ToLower());

            // preserve the original selection
            TextArea.SetSelection(start, end);
        }

        private void Uppercase()
        {

            // save the selection
            int start = TextArea.SelectionStart;
            int end = TextArea.SelectionEnd;

            // modify the selected text
            TextArea.ReplaceSelection(TextArea.GetTextRange(start, end - start).ToUpper());

            // preserve the original selection
            TextArea.SetSelection(start, end);
        }

        #endregion

        #region Indent / Outdent

        private void Indent()
        {
            // we use this hack to send "Shift+Tab" to scintilla, since there is no known API to indent,
            // although the indentation function exists. Pressing TAB with the editor focused confirms this.
            GenerateKeystrokes("{TAB}");
        }

        private void Outdent()
        {
            // we use this hack to send "Shift+Tab" to scintilla, since there is no known API to outdent,
            // although the indentation function exists. Pressing Shift+Tab with the editor focused confirms this.
            GenerateKeystrokes("+{TAB}");
        }

        private void GenerateKeystrokes(string keys)
        {
            
            TextArea.Focus();
            SendKeys.Send(keys);
            
        }

        #endregion

        #region Zoom

        private void ZoomIn()
        {
            TextArea.ZoomIn();
        }

        private void ZoomOut()
        {
            TextArea.ZoomOut();
        }

        private void ZoomDefault()
        {
            TextArea.Zoom = 0;
        }


        #endregion

      


        #region Utils

        public static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }

        public void InvokeIfNeeded(Action action)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(action);
            }
            else
            {
                action.Invoke();
            }
        }





        #endregion

        
    }
}

