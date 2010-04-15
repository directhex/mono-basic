' 
' Visual Basic.Net Compiler
' Copyright (C) 2004 - 2008 Rolf Bjarne Kvinge, RKvinge@novell.com
' 
' This library is free software; you can redistribute it and/or
' modify it under the terms of the GNU Lesser General Public
' License as published by the Free Software Foundation; either
' version 2.1 of the License, or (at your option) any later version.
' 
' This library is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
' Lesser General Public License for more details.
' 
' You should have received a copy of the GNU Lesser General Public
' License along with this library; if not, write to the Free Software
' Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
' 

Partial Class frmMain

    Friend WithEvents cmnuTest As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuDebugTest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuViewCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuViewCode2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuRunTest As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblBasepath As System.Windows.Forms.Label
    Friend WithEvents dlgBasepath As System.Windows.Forms.FolderBrowserDialog
    Private components As System.ComponentModel.IContainer
    Friend WithEvents lstImages As System.Windows.Forms.ImageList
    Friend WithEvents lblCompiler As System.Windows.Forms.Label
    Friend WithEvents cmdCompiler As System.Windows.Forms.Button
    Friend WithEvents dlgFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdBasepath As System.Windows.Forms.Button

    Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.mnuMain = New System.Windows.Forms.MenuStrip
        Me.mnuTools = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuViewCode = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuToolsRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.NewTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewQueuedTestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lstImages = New System.Windows.Forms.ImageList(Me.components)
        Me.lblBasepath = New System.Windows.Forms.Label
        Me.dlgBasepath = New System.Windows.Forms.FolderBrowserDialog
        Me.cmdBasepath = New System.Windows.Forms.Button
        Me.lblCompiler = New System.Windows.Forms.Label
        Me.cmdCompiler = New System.Windows.Forms.Button
        Me.dlgFile = New System.Windows.Forms.OpenFileDialog
        Me.cmnuTest = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuRunTest = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmnuViewCodeAndDebugTest = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuViewCode2 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuDebugTest = New System.Windows.Forms.ToolStripMenuItem
        Me.EditThisTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuIldasm = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuIldasmBoth = New System.Windows.Forms.ToolStripMenuItem
        Me.ReflectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VBNCAssemblyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VBCAssemblyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BothAssembliesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.CreateNewTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuDeleteTest = New System.Windows.Forms.ToolStripMenuItem
        Me.MakeErrorTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPause = New System.Windows.Forms.Button
        Me.cmdRun = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdStop = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.cmdVBCCompiler = New System.Windows.Forms.Button
        Me.cmdReload = New System.Windows.Forms.Button
        Me.cmnuTree = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RunTestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AllTestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FailedTestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SucceededTestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotRunTestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RunTestsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateNewTestInThisFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OnlyRefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateKnownFailurestxtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tabMain = New System.Windows.Forms.TabControl
        Me.pageSummary = New System.Windows.Forms.TabPage
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.txtRedTests = New System.Windows.Forms.Label
        Me.lblRedTests = New System.Windows.Forms.Label
        Me.lblGreenTests = New System.Windows.Forms.Label
        Me.lblYellowTests = New System.Windows.Forms.Label
        Me.txtGreenTests = New System.Windows.Forms.Label
        Me.txtYellowTests = New System.Windows.Forms.Label
        Me.txtQueue = New System.Windows.Forms.Label
        Me.lblQueue = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.lblNumberOfTests = New System.Windows.Forms.Label
        Me.txtAverageExecutionTime = New System.Windows.Forms.Label
        Me.lblAverageExecutionTime = New System.Windows.Forms.Label
        Me.txtExecutionTime = New System.Windows.Forms.Label
        Me.lblTestsRun = New System.Windows.Forms.Label
        Me.txtNumberOfTests = New System.Windows.Forms.Label
        Me.txtTestsRun = New System.Windows.Forms.Label
        Me.lblExecutionTime = New System.Windows.Forms.Label
        Me.pageTests = New System.Windows.Forms.TabPage
        Me.lstTests = New System.Windows.Forms.ListView
        Me.colName = New System.Windows.Forms.ColumnHeader
        Me.colResult = New System.Windows.Forms.ColumnHeader
        Me.colCategory = New System.Windows.Forms.ColumnHeader
        Me.colFailedVerification = New System.Windows.Forms.ColumnHeader
        Me.colDate = New System.Windows.Forms.ColumnHeader
        Me.pageTestResult = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.gridTestProperties = New System.Windows.Forms.PropertyGrid
        Me.txtTestResult = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.pageOldResults = New System.Windows.Forms.TabPage
        Me.txtOldResult = New System.Windows.Forms.TextBox
        Me.lstOldResults = New System.Windows.Forms.ListView
        Me.colOldResult = New System.Windows.Forms.ColumnHeader
        Me.colOldCompiler = New System.Windows.Forms.ColumnHeader
        Me.cmbCompiler = New System.Windows.Forms.ComboBox
        Me.cmbVBCCompiler = New System.Windows.Forms.ComboBox
        Me.cmbBasepath = New System.Windows.Forms.ComboBox
        Me.worker = New System.ComponentModel.BackgroundWorker
        Me.cmdSave = New System.Windows.Forms.Button
        Me.EnhancedProgressBar1 = New rt.EnhancedProgressBar
        Me.splitTests = New System.Windows.Forms.SplitContainer
        Me.txtTestMessage = New System.Windows.Forms.TextBox
        Me.colKnownFailureReason = New System.Windows.Forms.ColumnHeader
        Me.mnuMain.SuspendLayout()
        Me.cmnuTest.SuspendLayout()
        Me.cmnuTree.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.pageSummary.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pageTests.SuspendLayout()
        Me.pageTestResult.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pageOldResults.SuspendLayout()
        Me.splitTests.Panel1.SuspendLayout()
        Me.splitTests.Panel2.SuspendLayout()
        Me.splitTests.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTools})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(1031, 24)
        Me.mnuMain.TabIndex = 35
        '
        'mnuTools
        '
        Me.mnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuViewCode, Me.mnuToolsRefresh, Me.NewTestToolStripMenuItem, Me.ViewQueuedTestsToolStripMenuItem})
        Me.mnuTools.Name = "mnuTools"
        Me.mnuTools.Size = New System.Drawing.Size(44, 20)
        Me.mnuTools.Text = "Tools"
        '
        'cmnuViewCode
        '
        Me.cmnuViewCode.Name = "cmnuViewCode"
        Me.cmnuViewCode.Size = New System.Drawing.Size(173, 22)
        Me.cmnuViewCode.Text = "View code"
        '
        'mnuToolsRefresh
        '
        Me.mnuToolsRefresh.Name = "mnuToolsRefresh"
        Me.mnuToolsRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mnuToolsRefresh.Size = New System.Drawing.Size(173, 22)
        Me.mnuToolsRefresh.Text = "&Refresh"
        '
        'NewTestToolStripMenuItem
        '
        Me.NewTestToolStripMenuItem.Name = "NewTestToolStripMenuItem"
        Me.NewTestToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewTestToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.NewTestToolStripMenuItem.Text = "New test"
        '
        'ViewQueuedTestsToolStripMenuItem
        '
        Me.ViewQueuedTestsToolStripMenuItem.Name = "ViewQueuedTestsToolStripMenuItem"
        Me.ViewQueuedTestsToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ViewQueuedTestsToolStripMenuItem.Text = "View queued tests"
        '
        'lstImages
        '
        Me.lstImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.lstImages.ImageSize = New System.Drawing.Size(16, 16)
        Me.lstImages.TransparentColor = System.Drawing.Color.Transparent
        '
        'lblBasepath
        '
        Me.lblBasepath.Location = New System.Drawing.Point(9, 31)
        Me.lblBasepath.Name = "lblBasepath"
        Me.lblBasepath.Size = New System.Drawing.Size(100, 21)
        Me.lblBasepath.TabIndex = 5
        Me.lblBasepath.Text = "Tests:"
        '
        'dlgBasepath
        '
        Me.dlgBasepath.ShowNewFolderButton = False
        '
        'cmdBasepath
        '
        Me.cmdBasepath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdBasepath.Location = New System.Drawing.Point(1004, 27)
        Me.cmdBasepath.Name = "cmdBasepath"
        Me.cmdBasepath.Size = New System.Drawing.Size(25, 21)
        Me.cmdBasepath.TabIndex = 6
        Me.cmdBasepath.Text = "..."
        '
        'lblCompiler
        '
        Me.lblCompiler.Location = New System.Drawing.Point(9, 55)
        Me.lblCompiler.Name = "lblCompiler"
        Me.lblCompiler.Size = New System.Drawing.Size(100, 21)
        Me.lblCompiler.TabIndex = 8
        Me.lblCompiler.Text = "VBNC Compiler:"
        '
        'cmdCompiler
        '
        Me.cmdCompiler.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCompiler.Location = New System.Drawing.Point(1004, 55)
        Me.cmdCompiler.Name = "cmdCompiler"
        Me.cmdCompiler.Size = New System.Drawing.Size(25, 21)
        Me.cmdCompiler.TabIndex = 9
        Me.cmdCompiler.Text = "..."
        '
        'dlgFile
        '
        Me.dlgFile.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*"
        Me.dlgFile.Title = "Select the compiler to use"
        '
        'cmnuTest
        '
        Me.cmnuTest.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuRunTest, Me.ToolStripSeparator1, Me.cmnuViewCodeAndDebugTest, Me.cmnuViewCode2, Me.cmnuDebugTest, Me.EditThisTestToolStripMenuItem, Me.ToolStripSeparator3, Me.mnuIldasm, Me.ReflectToolStripMenuItem, Me.ToolStripSeparator2, Me.CreateNewTestToolStripMenuItem, Me.cmnuDeleteTest, Me.MakeErrorTestToolStripMenuItem})
        Me.cmnuTest.Name = "cmnuTest"
        Me.cmnuTest.Size = New System.Drawing.Size(379, 242)
        '
        'cmnuRunTest
        '
        Me.cmnuRunTest.Name = "cmnuRunTest"
        Me.cmnuRunTest.Size = New System.Drawing.Size(378, 22)
        Me.cmnuRunTest.Text = "Run this test"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(375, 6)
        '
        'cmnuViewCodeAndDebugTest
        '
        Me.cmnuViewCodeAndDebugTest.Name = "cmnuViewCodeAndDebugTest"
        Me.cmnuViewCodeAndDebugTest.Size = New System.Drawing.Size(378, 22)
        Me.cmnuViewCodeAndDebugTest.Text = "&View Code (external editor) and Set this test to be debugged"
        '
        'cmnuViewCode2
        '
        Me.cmnuViewCode2.Name = "cmnuViewCode2"
        Me.cmnuViewCode2.Size = New System.Drawing.Size(378, 22)
        Me.cmnuViewCode2.Text = "View code (external editor)"
        '
        'cmnuDebugTest
        '
        Me.cmnuDebugTest.Name = "cmnuDebugTest"
        Me.cmnuDebugTest.Size = New System.Drawing.Size(378, 22)
        Me.cmnuDebugTest.Text = "&Set this test to be debugged"
        '
        'EditThisTestToolStripMenuItem
        '
        Me.EditThisTestToolStripMenuItem.Name = "EditThisTestToolStripMenuItem"
        Me.EditThisTestToolStripMenuItem.Size = New System.Drawing.Size(378, 22)
        Me.EditThisTestToolStripMenuItem.Text = "Edit this test (internal editor)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(375, 6)
        '
        'mnuIldasm
        '
        Me.mnuIldasm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuIldasmBoth})
        Me.mnuIldasm.Name = "mnuIldasm"
        Me.mnuIldasm.Size = New System.Drawing.Size(378, 22)
        Me.mnuIldasm.Text = "Ildasm"
        '
        'mnuIldasmBoth
        '
        Me.mnuIldasmBoth.Name = "mnuIldasmBoth"
        Me.mnuIldasmBoth.Size = New System.Drawing.Size(161, 22)
        Me.mnuIldasmBoth.Text = "Both assemblies"
        '
        'ReflectToolStripMenuItem
        '
        Me.ReflectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VBNCAssemblyToolStripMenuItem, Me.VBCAssemblyToolStripMenuItem, Me.BothAssembliesToolStripMenuItem})
        Me.ReflectToolStripMenuItem.Name = "ReflectToolStripMenuItem"
        Me.ReflectToolStripMenuItem.Size = New System.Drawing.Size(378, 22)
        Me.ReflectToolStripMenuItem.Text = "Reflect"
        '
        'VBNCAssemblyToolStripMenuItem
        '
        Me.VBNCAssemblyToolStripMenuItem.Name = "VBNCAssemblyToolStripMenuItem"
        Me.VBNCAssemblyToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.VBNCAssemblyToolStripMenuItem.Text = "VBNC assembly"
        '
        'VBCAssemblyToolStripMenuItem
        '
        Me.VBCAssemblyToolStripMenuItem.Name = "VBCAssemblyToolStripMenuItem"
        Me.VBCAssemblyToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.VBCAssemblyToolStripMenuItem.Text = "VBC assembly"
        '
        'BothAssembliesToolStripMenuItem
        '
        Me.BothAssembliesToolStripMenuItem.Name = "BothAssembliesToolStripMenuItem"
        Me.BothAssembliesToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.BothAssembliesToolStripMenuItem.Text = "Both assemblies"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(375, 6)
        '
        'CreateNewTestToolStripMenuItem
        '
        Me.CreateNewTestToolStripMenuItem.Name = "CreateNewTestToolStripMenuItem"
        Me.CreateNewTestToolStripMenuItem.Size = New System.Drawing.Size(378, 22)
        Me.CreateNewTestToolStripMenuItem.Text = "Create new test"
        '
        'cmnuDeleteTest
        '
        Me.cmnuDeleteTest.Name = "cmnuDeleteTest"
        Me.cmnuDeleteTest.Size = New System.Drawing.Size(378, 22)
        Me.cmnuDeleteTest.Text = "Delete test"
        '
        'MakeErrorTestToolStripMenuItem
        '
        Me.MakeErrorTestToolStripMenuItem.Name = "MakeErrorTestToolStripMenuItem"
        Me.MakeErrorTestToolStripMenuItem.Size = New System.Drawing.Size(378, 22)
        Me.MakeErrorTestToolStripMenuItem.Text = "Make error test"
        '
        'cmdPause
        '
        Me.cmdPause.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPause.Location = New System.Drawing.Point(954, 157)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.Size = New System.Drawing.Size(75, 25)
        Me.cmdPause.TabIndex = 20
        Me.cmdPause.Tag = ""
        Me.cmdPause.Text = "Pause"
        '
        'cmdRun
        '
        Me.cmdRun.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRun.Location = New System.Drawing.Point(954, 126)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(75, 25)
        Me.cmdRun.TabIndex = 27
        Me.cmdRun.Tag = ""
        Me.cmdRun.Text = "Run all tests"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(954, 657)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 25)
        Me.cmdExit.TabIndex = 28
        Me.cmdExit.Tag = ""
        Me.cmdExit.Text = "&Exit"
        '
        'cmdStop
        '
        Me.cmdStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdStop.Location = New System.Drawing.Point(954, 188)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(75, 25)
        Me.cmdStop.TabIndex = 29
        Me.cmdStop.Tag = ""
        Me.cmdStop.Text = "Stop"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(9, 122)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(236, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Tests:"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(9, 82)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 21)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "VBC Compiler:"
        '
        'cmdVBCCompiler
        '
        Me.cmdVBCCompiler.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdVBCCompiler.Location = New System.Drawing.Point(1004, 82)
        Me.cmdVBCCompiler.Name = "cmdVBCCompiler"
        Me.cmdVBCCompiler.Size = New System.Drawing.Size(25, 21)
        Me.cmdVBCCompiler.TabIndex = 38
        Me.cmdVBCCompiler.Text = "..."
        '
        'cmdReload
        '
        Me.cmdReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdReload.Location = New System.Drawing.Point(954, 338)
        Me.cmdReload.Name = "cmdReload"
        Me.cmdReload.Size = New System.Drawing.Size(75, 25)
        Me.cmdReload.TabIndex = 39
        Me.cmdReload.Tag = ""
        Me.cmdReload.Text = "&Reload list"
        '
        'cmnuTree
        '
        Me.cmnuTree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunTestsToolStripMenuItem, Me.CreateNewTestInThisFolderToolStripMenuItem, Me.OnlyRefreshToolStripMenuItem, Me.CreateKnownFailurestxtToolStripMenuItem})
        Me.cmnuTree.Name = "cmnuTree"
        Me.cmnuTree.Size = New System.Drawing.Size(226, 92)
        '
        'RunTestsToolStripMenuItem
        '
        Me.RunTestsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllTestsToolStripMenuItem, Me.FailedTestsToolStripMenuItem, Me.SucceededTestsToolStripMenuItem, Me.NotRunTestsToolStripMenuItem, Me.RunTestsToolStripMenuItem1})
        Me.RunTestsToolStripMenuItem.Name = "RunTestsToolStripMenuItem"
        Me.RunTestsToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.RunTestsToolStripMenuItem.Text = "&Run tests"
        '
        'AllTestsToolStripMenuItem
        '
        Me.AllTestsToolStripMenuItem.Name = "AllTestsToolStripMenuItem"
        Me.AllTestsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AllTestsToolStripMenuItem.Text = "&All tests"
        '
        'FailedTestsToolStripMenuItem
        '
        Me.FailedTestsToolStripMenuItem.Name = "FailedTestsToolStripMenuItem"
        Me.FailedTestsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.FailedTestsToolStripMenuItem.Text = "&Failed tests"
        '
        'SucceededTestsToolStripMenuItem
        '
        Me.SucceededTestsToolStripMenuItem.Name = "SucceededTestsToolStripMenuItem"
        Me.SucceededTestsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SucceededTestsToolStripMenuItem.Text = "&Succeeded tests"
        '
        'NotRunTestsToolStripMenuItem
        '
        Me.NotRunTestsToolStripMenuItem.Name = "NotRunTestsToolStripMenuItem"
        Me.NotRunTestsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.NotRunTestsToolStripMenuItem.Text = "&Not run tests"
        '
        'RunTestsToolStripMenuItem1
        '
        Me.RunTestsToolStripMenuItem1.Name = "RunTestsToolStripMenuItem1"
        Me.RunTestsToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.RunTestsToolStripMenuItem1.Text = "&Run tests"
        '
        'CreateNewTestInThisFolderToolStripMenuItem
        '
        Me.CreateNewTestInThisFolderToolStripMenuItem.Name = "CreateNewTestInThisFolderToolStripMenuItem"
        Me.CreateNewTestInThisFolderToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.CreateNewTestInThisFolderToolStripMenuItem.Text = "Create new test in this folder"
        '
        'OnlyRefreshToolStripMenuItem
        '
        Me.OnlyRefreshToolStripMenuItem.Name = "OnlyRefreshToolStripMenuItem"
        Me.OnlyRefreshToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.OnlyRefreshToolStripMenuItem.Text = "Only refresh"
        '
        'CreateKnownFailurestxtToolStripMenuItem
        '
        Me.CreateKnownFailurestxtToolStripMenuItem.Name = "CreateKnownFailurestxtToolStripMenuItem"
        Me.CreateKnownFailurestxtToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.CreateKnownFailurestxtToolStripMenuItem.Text = "Create KnownFailures.txt"
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Controls.Add(Me.pageSummary)
        Me.tabMain.Controls.Add(Me.pageTests)
        Me.tabMain.Controls.Add(Me.pageTestResult)
        Me.tabMain.Controls.Add(Me.pageOldResults)
        Me.tabMain.Location = New System.Drawing.Point(12, 138)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(936, 544)
        Me.tabMain.TabIndex = 43
        '
        'pageSummary
        '
        Me.pageSummary.Controls.Add(Me.TableLayoutPanel2)
        Me.pageSummary.Controls.Add(Me.TableLayoutPanel1)
        Me.pageSummary.Location = New System.Drawing.Point(4, 22)
        Me.pageSummary.Name = "pageSummary"
        Me.pageSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.pageSummary.Size = New System.Drawing.Size(837, 416)
        Me.pageSummary.TabIndex = 0
        Me.pageSummary.Text = "Summary"
        Me.pageSummary.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtRedTests, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblRedTests, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblGreenTests, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblYellowTests, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtGreenTests, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtYellowTests, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtQueue, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblQueue, 0, 3)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 167)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(819, 142)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'txtRedTests
        '
        Me.txtRedTests.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtRedTests.AutoSize = True
        Me.txtRedTests.Location = New System.Drawing.Point(617, 81)
        Me.txtRedTests.Name = "txtRedTests"
        Me.txtRedTests.Size = New System.Drawing.Size(0, 13)
        Me.txtRedTests.TabIndex = 7
        '
        'lblRedTests
        '
        Me.lblRedTests.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRedTests.AutoSize = True
        Me.lblRedTests.Location = New System.Drawing.Point(3, 81)
        Me.lblRedTests.Name = "lblRedTests"
        Me.lblRedTests.Size = New System.Drawing.Size(57, 13)
        Me.lblRedTests.TabIndex = 6
        Me.lblRedTests.Text = "Red tests:"
        '
        'lblGreenTests
        '
        Me.lblGreenTests.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblGreenTests.AutoSize = True
        Me.lblGreenTests.Location = New System.Drawing.Point(3, 46)
        Me.lblGreenTests.Name = "lblGreenTests"
        Me.lblGreenTests.Size = New System.Drawing.Size(67, 13)
        Me.lblGreenTests.TabIndex = 0
        Me.lblGreenTests.Text = "Green tests:"
        '
        'lblYellowTests
        '
        Me.lblYellowTests.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblYellowTests.AutoSize = True
        Me.lblYellowTests.Location = New System.Drawing.Point(3, 11)
        Me.lblYellowTests.Name = "lblYellowTests"
        Me.lblYellowTests.Size = New System.Drawing.Size(75, 13)
        Me.lblYellowTests.TabIndex = 4
        Me.lblYellowTests.Text = "Tests not run:"
        '
        'txtGreenTests
        '
        Me.txtGreenTests.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtGreenTests.AutoSize = True
        Me.txtGreenTests.Location = New System.Drawing.Point(617, 46)
        Me.txtGreenTests.Name = "txtGreenTests"
        Me.txtGreenTests.Size = New System.Drawing.Size(0, 13)
        Me.txtGreenTests.TabIndex = 3
        '
        'txtYellowTests
        '
        Me.txtYellowTests.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtYellowTests.AutoSize = True
        Me.txtYellowTests.Location = New System.Drawing.Point(617, 11)
        Me.txtYellowTests.Name = "txtYellowTests"
        Me.txtYellowTests.Size = New System.Drawing.Size(0, 13)
        Me.txtYellowTests.TabIndex = 5
        '
        'txtQueue
        '
        Me.txtQueue.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtQueue.AutoSize = True
        Me.txtQueue.Location = New System.Drawing.Point(617, 117)
        Me.txtQueue.Name = "txtQueue"
        Me.txtQueue.Size = New System.Drawing.Size(0, 13)
        Me.txtQueue.TabIndex = 9
        '
        'lblQueue
        '
        Me.lblQueue.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblQueue.AutoSize = True
        Me.lblQueue.Location = New System.Drawing.Point(3, 117)
        Me.lblQueue.Name = "lblQueue"
        Me.lblQueue.Size = New System.Drawing.Size(81, 13)
        Me.lblQueue.TabIndex = 8
        Me.lblQueue.Text = "Tests in queue:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblNumberOfTests, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAverageExecutionTime, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAverageExecutionTime, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtExecutionTime, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTestsRun, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNumberOfTests, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTestsRun, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblExecutionTime, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 17)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(819, 144)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'lblNumberOfTests
        '
        Me.lblNumberOfTests.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNumberOfTests.AutoSize = True
        Me.lblNumberOfTests.Location = New System.Drawing.Point(3, 11)
        Me.lblNumberOfTests.Name = "lblNumberOfTests"
        Me.lblNumberOfTests.Size = New System.Drawing.Size(114, 13)
        Me.lblNumberOfTests.TabIndex = 5
        Me.lblNumberOfTests.Text = "Total number of tests:"
        '
        'txtAverageExecutionTime
        '
        Me.txtAverageExecutionTime.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtAverageExecutionTime.AutoSize = True
        Me.txtAverageExecutionTime.Location = New System.Drawing.Point(617, 119)
        Me.txtAverageExecutionTime.Name = "txtAverageExecutionTime"
        Me.txtAverageExecutionTime.Size = New System.Drawing.Size(0, 13)
        Me.txtAverageExecutionTime.TabIndex = 7
        '
        'lblAverageExecutionTime
        '
        Me.lblAverageExecutionTime.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblAverageExecutionTime.AutoSize = True
        Me.lblAverageExecutionTime.Location = New System.Drawing.Point(3, 119)
        Me.lblAverageExecutionTime.Name = "lblAverageExecutionTime"
        Me.lblAverageExecutionTime.Size = New System.Drawing.Size(166, 13)
        Me.lblAverageExecutionTime.TabIndex = 6
        Me.lblAverageExecutionTime.Text = "Average execution time per test:"
        '
        'txtExecutionTime
        '
        Me.txtExecutionTime.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtExecutionTime.AutoSize = True
        Me.txtExecutionTime.Location = New System.Drawing.Point(617, 83)
        Me.txtExecutionTime.Name = "txtExecutionTime"
        Me.txtExecutionTime.Size = New System.Drawing.Size(0, 13)
        Me.txtExecutionTime.TabIndex = 5
        '
        'lblTestsRun
        '
        Me.lblTestsRun.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTestsRun.AutoSize = True
        Me.lblTestsRun.Location = New System.Drawing.Point(3, 47)
        Me.lblTestsRun.Name = "lblTestsRun"
        Me.lblTestsRun.Size = New System.Drawing.Size(56, 13)
        Me.lblTestsRun.TabIndex = 1
        Me.lblTestsRun.Text = "Tests run:"
        '
        'txtNumberOfTests
        '
        Me.txtNumberOfTests.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtNumberOfTests.AutoSize = True
        Me.txtNumberOfTests.Location = New System.Drawing.Point(617, 11)
        Me.txtNumberOfTests.Name = "txtNumberOfTests"
        Me.txtNumberOfTests.Size = New System.Drawing.Size(0, 13)
        Me.txtNumberOfTests.TabIndex = 2
        '
        'txtTestsRun
        '
        Me.txtTestsRun.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtTestsRun.AutoSize = True
        Me.txtTestsRun.Location = New System.Drawing.Point(617, 47)
        Me.txtTestsRun.Name = "txtTestsRun"
        Me.txtTestsRun.Size = New System.Drawing.Size(0, 13)
        Me.txtTestsRun.TabIndex = 3
        '
        'lblExecutionTime
        '
        Me.lblExecutionTime.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblExecutionTime.AutoSize = True
        Me.lblExecutionTime.Location = New System.Drawing.Point(3, 83)
        Me.lblExecutionTime.Name = "lblExecutionTime"
        Me.lblExecutionTime.Size = New System.Drawing.Size(108, 13)
        Me.lblExecutionTime.TabIndex = 4
        Me.lblExecutionTime.Text = "Total execution time:"
        '
        'pageTests
        '
        Me.pageTests.Controls.Add(Me.splitTests)
        Me.pageTests.Location = New System.Drawing.Point(4, 22)
        Me.pageTests.Name = "pageTests"
        Me.pageTests.Padding = New System.Windows.Forms.Padding(3)
        Me.pageTests.Size = New System.Drawing.Size(928, 518)
        Me.pageTests.TabIndex = 2
        Me.pageTests.Text = "Tests"
        Me.pageTests.UseVisualStyleBackColor = True
        '
        'lstTests
        '
        Me.lstTests.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colResult, Me.colCategory, Me.colFailedVerification, Me.colDate, Me.colKnownFailureReason})
        Me.lstTests.ContextMenuStrip = Me.cmnuTest
        Me.lstTests.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstTests.FullRowSelect = True
        Me.lstTests.HideSelection = False
        Me.lstTests.LargeImageList = Me.lstImages
        Me.lstTests.Location = New System.Drawing.Point(0, 0)
        Me.lstTests.Name = "lstTests"
        Me.lstTests.Size = New System.Drawing.Size(922, 482)
        Me.lstTests.SmallImageList = Me.lstImages
        Me.lstTests.StateImageList = Me.lstImages
        Me.lstTests.TabIndex = 33
        Me.lstTests.UseCompatibleStateImageBehavior = False
        Me.lstTests.View = System.Windows.Forms.View.Details
        '
        'colName
        '
        Me.colName.Name = "colName"
        Me.colName.Text = "Name"
        Me.colName.Width = 80
        '
        'colResult
        '
        Me.colResult.Text = "Result"
        Me.colResult.Width = 80
        '
        'colCategory
        '
        Me.colCategory.Text = "Category"
        Me.colCategory.Width = 83
        '
        'colFailedVerification
        '
        Me.colFailedVerification.Text = "Failed Verification"
        Me.colFailedVerification.Width = 249
        '
        'colDate
        '
        Me.colDate.Text = "Date"
        Me.colDate.Width = 80
        '
        'pageTestResult
        '
        Me.pageTestResult.Controls.Add(Me.GroupBox1)
        Me.pageTestResult.Location = New System.Drawing.Point(4, 22)
        Me.pageTestResult.Name = "pageTestResult"
        Me.pageTestResult.Padding = New System.Windows.Forms.Padding(3)
        Me.pageTestResult.Size = New System.Drawing.Size(928, 518)
        Me.pageTestResult.TabIndex = 1
        Me.pageTestResult.Text = "Test result"
        Me.pageTestResult.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gridTestProperties)
        Me.GroupBox1.Controls.Add(Me.txtTestResult)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtMessage)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(922, 512)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Test Summary:"
        '
        'gridTestProperties
        '
        Me.gridTestProperties.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridTestProperties.HelpVisible = False
        Me.gridTestProperties.Location = New System.Drawing.Point(6, 66)
        Me.gridTestProperties.Name = "gridTestProperties"
        Me.gridTestProperties.PropertySort = System.Windows.Forms.PropertySort.Alphabetical
        Me.gridTestProperties.Size = New System.Drawing.Size(908, 203)
        Me.gridTestProperties.TabIndex = 11
        Me.gridTestProperties.ToolbarVisible = False
        '
        'txtTestResult
        '
        Me.txtTestResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTestResult.BackColor = System.Drawing.Color.White
        Me.txtTestResult.Location = New System.Drawing.Point(6, 40)
        Me.txtTestResult.Name = "txtTestResult"
        Me.txtTestResult.ReadOnly = True
        Me.txtTestResult.Size = New System.Drawing.Size(908, 21)
        Me.txtTestResult.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Test result:"
        '
        'txtMessage
        '
        Me.txtMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMessage.BackColor = System.Drawing.Color.White
        Me.txtMessage.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.Location = New System.Drawing.Point(6, 275)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ReadOnly = True
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMessage.Size = New System.Drawing.Size(908, 231)
        Me.txtMessage.TabIndex = 8
        Me.txtMessage.WordWrap = False
        '
        'pageOldResults
        '
        Me.pageOldResults.Controls.Add(Me.txtOldResult)
        Me.pageOldResults.Controls.Add(Me.lstOldResults)
        Me.pageOldResults.Location = New System.Drawing.Point(4, 22)
        Me.pageOldResults.Name = "pageOldResults"
        Me.pageOldResults.Padding = New System.Windows.Forms.Padding(3)
        Me.pageOldResults.Size = New System.Drawing.Size(837, 416)
        Me.pageOldResults.TabIndex = 3
        Me.pageOldResults.Text = "Old results"
        Me.pageOldResults.UseVisualStyleBackColor = True
        '
        'txtOldResult
        '
        Me.txtOldResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOldResult.Location = New System.Drawing.Point(3, 215)
        Me.txtOldResult.Multiline = True
        Me.txtOldResult.Name = "txtOldResult"
        Me.txtOldResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOldResult.Size = New System.Drawing.Size(584, 195)
        Me.txtOldResult.TabIndex = 1
        '
        'lstOldResults
        '
        Me.lstOldResults.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstOldResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colOldResult, Me.colOldCompiler})
        Me.lstOldResults.FullRowSelect = True
        Me.lstOldResults.LargeImageList = Me.lstImages
        Me.lstOldResults.Location = New System.Drawing.Point(3, 6)
        Me.lstOldResults.Name = "lstOldResults"
        Me.lstOldResults.Size = New System.Drawing.Size(584, 203)
        Me.lstOldResults.SmallImageList = Me.lstImages
        Me.lstOldResults.StateImageList = Me.lstImages
        Me.lstOldResults.TabIndex = 0
        Me.lstOldResults.UseCompatibleStateImageBehavior = False
        Me.lstOldResults.View = System.Windows.Forms.View.Details
        '
        'colOldResult
        '
        Me.colOldResult.Text = "Result"
        Me.colOldResult.Width = 154
        '
        'colOldCompiler
        '
        Me.colOldCompiler.Text = "Compiler"
        Me.colOldCompiler.Width = 142
        '
        'cmbCompiler
        '
        Me.cmbCompiler.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCompiler.FormattingEnabled = True
        Me.cmbCompiler.Location = New System.Drawing.Point(129, 55)
        Me.cmbCompiler.Name = "cmbCompiler"
        Me.cmbCompiler.Size = New System.Drawing.Size(869, 21)
        Me.cmbCompiler.TabIndex = 19
        '
        'cmbVBCCompiler
        '
        Me.cmbVBCCompiler.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbVBCCompiler.FormattingEnabled = True
        Me.cmbVBCCompiler.Location = New System.Drawing.Point(129, 82)
        Me.cmbVBCCompiler.Name = "cmbVBCCompiler"
        Me.cmbVBCCompiler.Size = New System.Drawing.Size(869, 21)
        Me.cmbVBCCompiler.TabIndex = 37
        '
        'cmbBasepath
        '
        Me.cmbBasepath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbBasepath.FormattingEnabled = True
        Me.cmbBasepath.Location = New System.Drawing.Point(129, 28)
        Me.cmbBasepath.Name = "cmbBasepath"
        Me.cmbBasepath.Size = New System.Drawing.Size(869, 21)
        Me.cmbBasepath.TabIndex = 18
        '
        'worker
        '
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Location = New System.Drawing.Point(954, 369)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 25)
        Me.cmdSave.TabIndex = 44
        Me.cmdSave.Tag = ""
        Me.cmdSave.Text = "&Save list"
        '
        'EnhancedProgressBar1
        '
        Me.EnhancedProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnhancedProgressBar1.Location = New System.Drawing.Point(10, 695)
        Me.EnhancedProgressBar1.Name = "EnhancedProgressBar1"
        Me.EnhancedProgressBar1.Size = New System.Drawing.Size(938, 27)
        Me.EnhancedProgressBar1.TabIndex = 0
        Me.EnhancedProgressBar1.ValueCount = 3
        '
        'splitTests
        '
        Me.splitTests.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitTests.Location = New System.Drawing.Point(3, 3)
        Me.splitTests.Name = "splitTests"
        Me.splitTests.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitTests.Panel1
        '
        Me.splitTests.Panel1.Controls.Add(Me.lstTests)
        '
        'splitTests.Panel2
        '
        Me.splitTests.Panel2.Controls.Add(Me.txtTestMessage)
        Me.splitTests.Size = New System.Drawing.Size(922, 512)
        Me.splitTests.SplitterDistance = 482
        Me.splitTests.TabIndex = 34
        '
        'txtTestMessage
        '
        Me.txtTestMessage.BackColor = System.Drawing.Color.White
        Me.txtTestMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTestMessage.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTestMessage.Location = New System.Drawing.Point(0, 0)
        Me.txtTestMessage.Multiline = True
        Me.txtTestMessage.Name = "txtTestMessage"
        Me.txtTestMessage.ReadOnly = True
        Me.txtTestMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTestMessage.Size = New System.Drawing.Size(922, 26)
        Me.txtTestMessage.TabIndex = 9
        Me.txtTestMessage.WordWrap = False
        '
        'colKnownFailureReason
        '
        Me.colKnownFailureReason.Text = "Known Failure Reason"
        Me.colKnownFailureReason.Width = 120
        '
        'frmMain
        '
        Me.ClientSize = New System.Drawing.Size(1031, 723)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.cmbCompiler)
        Me.Controls.Add(Me.cmbVBCCompiler)
        Me.Controls.Add(Me.cmdVBCCompiler)
        Me.Controls.Add(Me.cmdReload)
        Me.Controls.Add(Me.mnuMain)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.cmdRun)
        Me.Controls.Add(Me.EnhancedProgressBar1)
        Me.Controls.Add(Me.cmdPause)
        Me.Controls.Add(Me.cmbBasepath)
        Me.Controls.Add(Me.lblCompiler)
        Me.Controls.Add(Me.cmdCompiler)
        Me.Controls.Add(Me.lblBasepath)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmdBasepath)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(800, 550)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Regression Tester"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.cmnuTest.ResumeLayout(False)
        Me.cmnuTree.ResumeLayout(False)
        Me.tabMain.ResumeLayout(False)
        Me.pageSummary.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.pageTests.ResumeLayout(False)
        Me.pageTestResult.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pageOldResults.ResumeLayout(False)
        Me.pageOldResults.PerformLayout()
        Me.splitTests.Panel1.ResumeLayout(False)
        Me.splitTests.Panel2.ResumeLayout(False)
        Me.splitTests.Panel2.PerformLayout()
        Me.splitTests.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuToolsRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbBasepath As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCompiler As System.Windows.Forms.ComboBox
    Friend WithEvents cmdPause As System.Windows.Forms.Button
    Friend WithEvents cmdRun As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents EnhancedProgressBar1 As rt.EnhancedProgressBar
    Friend WithEvents cmnuViewCodeAndDebugTest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbVBCCompiler As System.Windows.Forms.ComboBox
    Friend WithEvents cmdVBCCompiler As System.Windows.Forms.Button
    Friend WithEvents cmdReload As System.Windows.Forms.Button
    Friend WithEvents CreateNewTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditThisTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReflectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VBNCAssemblyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VBCAssemblyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BothAssembliesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents pageSummary As System.Windows.Forms.TabPage
    Friend WithEvents pageTestResult As System.Windows.Forms.TabPage
    Friend WithEvents pageTests As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gridTestProperties As System.Windows.Forms.PropertyGrid
    Friend WithEvents txtTestResult As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents lstTests As System.Windows.Forms.ListView
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtRedTests As System.Windows.Forms.Label
    Friend WithEvents lblRedTests As System.Windows.Forms.Label
    Friend WithEvents lblGreenTests As System.Windows.Forms.Label
    Friend WithEvents lblYellowTests As System.Windows.Forms.Label
    Friend WithEvents txtGreenTests As System.Windows.Forms.Label
    Friend WithEvents txtYellowTests As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblNumberOfTests As System.Windows.Forms.Label
    Friend WithEvents txtAverageExecutionTime As System.Windows.Forms.Label
    Friend WithEvents lblAverageExecutionTime As System.Windows.Forms.Label
    Friend WithEvents txtExecutionTime As System.Windows.Forms.Label
    Friend WithEvents lblTestsRun As System.Windows.Forms.Label
    Friend WithEvents txtNumberOfTests As System.Windows.Forms.Label
    Friend WithEvents txtTestsRun As System.Windows.Forms.Label
    Friend WithEvents lblExecutionTime As System.Windows.Forms.Label
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colResult As System.Windows.Forms.ColumnHeader
    Friend WithEvents colFailedVerification As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmnuTree As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RunTestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllTestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FailedTestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SucceededTestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CreateNewTestInThisFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewQueuedTestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotRunTestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunTestsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtQueue As System.Windows.Forms.Label
    Friend WithEvents lblQueue As System.Windows.Forms.Label
    Friend WithEvents OnlyRefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pageOldResults As System.Windows.Forms.TabPage
    Friend WithEvents lstOldResults As System.Windows.Forms.ListView
    Friend WithEvents colOldResult As System.Windows.Forms.ColumnHeader
    Friend WithEvents colOldCompiler As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtOldResult As System.Windows.Forms.TextBox
    Friend WithEvents colCategory As System.Windows.Forms.ColumnHeader
    Friend WithEvents worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents MakeErrorTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateKnownFailurestxtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuIldasm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuIldasmBoth As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmnuDeleteTest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents splitTests As System.Windows.Forms.SplitContainer
    Friend WithEvents txtTestMessage As System.Windows.Forms.TextBox
    Friend WithEvents colKnownFailureReason As System.Windows.Forms.ColumnHeader
End Class
