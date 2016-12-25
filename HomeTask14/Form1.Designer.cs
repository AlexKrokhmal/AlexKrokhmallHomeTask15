namespace HomeTask14
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainViewGroupBox = new System.Windows.Forms.GroupBox();
            this.addAreaGroupBox = new System.Windows.Forms.GroupBox();
            this.queueAddGroupBox = new System.Windows.Forms.GroupBox();
            this.resultValueAddEmbeddedQueueBasedLabel = new System.Windows.Forms.Label();
            this.resultValueAddLinkedListBasedQueueLabel = new System.Windows.Forms.Label();
            this.resultValueAddDynamicArrayBasedQueueLabel = new System.Windows.Forms.Label();
            this.resultAddEmbeddedBasedQueueLabel = new System.Windows.Forms.Label();
            this.resultValueAddArrayBasedQueueLabel = new System.Windows.Forms.Label();
            this.runTestAddArrayBasedQueueButton = new System.Windows.Forms.Button();
            this.resultAddLinkedListBasedQueueLabel = new System.Windows.Forms.Label();
            this.resultAddDynamicArrayBasedQueueLabel = new System.Windows.Forms.Label();
            this.resultAddArrayBasedQueueLabel = new System.Windows.Forms.Label();
            this.stackAddGroupBox = new System.Windows.Forms.GroupBox();
            this.resultValueAddEmbeddedStackBasedLabel = new System.Windows.Forms.Label();
            this.resultValueAddLinkedListBasedStackLabel = new System.Windows.Forms.Label();
            this.resultValueAddDynamicArrayBasedStackLabel = new System.Windows.Forms.Label();
            this.resultAddEmbeddedBasedStackLabel = new System.Windows.Forms.Label();
            this.resultValueAddArrayBasedStackLabel = new System.Windows.Forms.Label();
            this.runTestAddArrayBasedStackButton = new System.Windows.Forms.Button();
            this.resultAddLinkedListBasedStackLabel = new System.Windows.Forms.Label();
            this.resultAddDynamicArrayBasedStackLabel = new System.Windows.Forms.Label();
            this.resultAddArrayBasedStackLabel = new System.Windows.Forms.Label();
            this.numberOfElemtsToAddAndRemovedLabel = new System.Windows.Forms.Label();
            this.numberOfElementsToAddTextBox = new System.Windows.Forms.TextBox();
            this.resultValueRemoveEmbeddedStackBasedLabel = new System.Windows.Forms.Label();
            this.resultValueRemoveLinkedListBasedStackLabel = new System.Windows.Forms.Label();
            this.resultValueRemoveDynamicArrayBasedStackLabel = new System.Windows.Forms.Label();
            this.resultRemoveEmbeddedBasedStackLabel = new System.Windows.Forms.Label();
            this.resultValueRemoveArrayBasedStackLabel = new System.Windows.Forms.Label();
            this.resultRemoveLinkedListBasedStackLabel = new System.Windows.Forms.Label();
            this.resultRemoveDynamicArrayBasedStackLabel = new System.Windows.Forms.Label();
            this.resultRemoveArrayBasedStackLabel = new System.Windows.Forms.Label();
            this.resultValueRemoveEmbeddedQueueBasedLabel = new System.Windows.Forms.Label();
            this.resultValueRemoveLinkedListBasedQueueLabel = new System.Windows.Forms.Label();
            this.resultValueRemoveDynamicArrayBasedQueueLabel = new System.Windows.Forms.Label();
            this.resultRemoveEmbeddedBasedQueueLabel = new System.Windows.Forms.Label();
            this.resultValueRemoveArrayBasedQueueLabel = new System.Windows.Forms.Label();
            this.resultRemoveLinkedListBasedQueueLabel = new System.Windows.Forms.Label();
            this.resultRemoveDynamicArrayBasedQueueLabel = new System.Windows.Forms.Label();
            this.resultRemoveArrayBasedQueueLabel = new System.Windows.Forms.Label();
            this.mainViewGroupBox.SuspendLayout();
            this.addAreaGroupBox.SuspendLayout();
            this.queueAddGroupBox.SuspendLayout();
            this.stackAddGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainViewGroupBox
            // 
            this.mainViewGroupBox.Controls.Add(this.addAreaGroupBox);
            this.mainViewGroupBox.Location = new System.Drawing.Point(12, 12);
            this.mainViewGroupBox.Name = "mainViewGroupBox";
            this.mainViewGroupBox.Size = new System.Drawing.Size(756, 505);
            this.mainViewGroupBox.TabIndex = 0;
            this.mainViewGroupBox.TabStop = false;
            this.mainViewGroupBox.Text = "Main View";
            this.mainViewGroupBox.Enter += new System.EventHandler(this.mainViewGroupBox_Enter);
            // 
            // addAreaGroupBox
            // 
            this.addAreaGroupBox.Controls.Add(this.queueAddGroupBox);
            this.addAreaGroupBox.Controls.Add(this.stackAddGroupBox);
            this.addAreaGroupBox.Controls.Add(this.numberOfElemtsToAddAndRemovedLabel);
            this.addAreaGroupBox.Controls.Add(this.numberOfElementsToAddTextBox);
            this.addAreaGroupBox.Location = new System.Drawing.Point(9, 38);
            this.addAreaGroupBox.Name = "addAreaGroupBox";
            this.addAreaGroupBox.Size = new System.Drawing.Size(711, 450);
            this.addAreaGroupBox.TabIndex = 1;
            this.addAreaGroupBox.TabStop = false;
            this.addAreaGroupBox.Text = "Add Area";
            this.addAreaGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // queueAddGroupBox
            // 
            this.queueAddGroupBox.Controls.Add(this.resultValueRemoveEmbeddedQueueBasedLabel);
            this.queueAddGroupBox.Controls.Add(this.resultValueRemoveLinkedListBasedQueueLabel);
            this.queueAddGroupBox.Controls.Add(this.resultValueRemoveDynamicArrayBasedQueueLabel);
            this.queueAddGroupBox.Controls.Add(this.resultRemoveEmbeddedBasedQueueLabel);
            this.queueAddGroupBox.Controls.Add(this.resultValueRemoveArrayBasedQueueLabel);
            this.queueAddGroupBox.Controls.Add(this.resultRemoveLinkedListBasedQueueLabel);
            this.queueAddGroupBox.Controls.Add(this.resultRemoveDynamicArrayBasedQueueLabel);
            this.queueAddGroupBox.Controls.Add(this.resultRemoveArrayBasedQueueLabel);
            this.queueAddGroupBox.Controls.Add(this.resultValueAddEmbeddedQueueBasedLabel);
            this.queueAddGroupBox.Controls.Add(this.resultValueAddLinkedListBasedQueueLabel);
            this.queueAddGroupBox.Controls.Add(this.resultValueAddDynamicArrayBasedQueueLabel);
            this.queueAddGroupBox.Controls.Add(this.resultAddEmbeddedBasedQueueLabel);
            this.queueAddGroupBox.Controls.Add(this.resultValueAddArrayBasedQueueLabel);
            this.queueAddGroupBox.Controls.Add(this.runTestAddArrayBasedQueueButton);
            this.queueAddGroupBox.Controls.Add(this.resultAddLinkedListBasedQueueLabel);
            this.queueAddGroupBox.Controls.Add(this.resultAddDynamicArrayBasedQueueLabel);
            this.queueAddGroupBox.Controls.Add(this.resultAddArrayBasedQueueLabel);
            this.queueAddGroupBox.Location = new System.Drawing.Point(327, 65);
            this.queueAddGroupBox.Name = "queueAddGroupBox";
            this.queueAddGroupBox.Size = new System.Drawing.Size(300, 300);
            this.queueAddGroupBox.TabIndex = 5;
            this.queueAddGroupBox.TabStop = false;
            this.queueAddGroupBox.Text = "Queue";
            // 
            // resultValueAddEmbeddedQueueBasedLabel
            // 
            this.resultValueAddEmbeddedQueueBasedLabel.AutoSize = true;
            this.resultValueAddEmbeddedQueueBasedLabel.Location = new System.Drawing.Point(209, 117);
            this.resultValueAddEmbeddedQueueBasedLabel.Name = "resultValueAddEmbeddedQueueBasedLabel";
            this.resultValueAddEmbeddedQueueBasedLabel.Size = new System.Drawing.Size(46, 17);
            this.resultValueAddEmbeddedQueueBasedLabel.TabIndex = 4;
            this.resultValueAddEmbeddedQueueBasedLabel.Text = "empty";
            // 
            // resultValueAddLinkedListBasedQueueLabel
            // 
            this.resultValueAddLinkedListBasedQueueLabel.AutoSize = true;
            this.resultValueAddLinkedListBasedQueueLabel.Location = new System.Drawing.Point(209, 90);
            this.resultValueAddLinkedListBasedQueueLabel.Name = "resultValueAddLinkedListBasedQueueLabel";
            this.resultValueAddLinkedListBasedQueueLabel.Size = new System.Drawing.Size(46, 17);
            this.resultValueAddLinkedListBasedQueueLabel.TabIndex = 4;
            this.resultValueAddLinkedListBasedQueueLabel.Text = "empty";
            // 
            // resultValueAddDynamicArrayBasedQueueLabel
            // 
            this.resultValueAddDynamicArrayBasedQueueLabel.AutoSize = true;
            this.resultValueAddDynamicArrayBasedQueueLabel.Location = new System.Drawing.Point(209, 64);
            this.resultValueAddDynamicArrayBasedQueueLabel.Name = "resultValueAddDynamicArrayBasedQueueLabel";
            this.resultValueAddDynamicArrayBasedQueueLabel.Size = new System.Drawing.Size(46, 17);
            this.resultValueAddDynamicArrayBasedQueueLabel.TabIndex = 4;
            this.resultValueAddDynamicArrayBasedQueueLabel.Text = "empty";
            // 
            // resultAddEmbeddedBasedQueueLabel
            // 
            this.resultAddEmbeddedBasedQueueLabel.AutoSize = true;
            this.resultAddEmbeddedBasedQueueLabel.Location = new System.Drawing.Point(32, 117);
            this.resultAddEmbeddedBasedQueueLabel.Name = "resultAddEmbeddedBasedQueueLabel";
            this.resultAddEmbeddedBasedQueueLabel.Size = new System.Drawing.Size(134, 17);
            this.resultAddEmbeddedBasedQueueLabel.TabIndex = 2;
            this.resultAddEmbeddedBasedQueueLabel.Text = "C # Embedded Add:";
            // 
            // resultValueAddArrayBasedQueueLabel
            // 
            this.resultValueAddArrayBasedQueueLabel.AutoSize = true;
            this.resultValueAddArrayBasedQueueLabel.Location = new System.Drawing.Point(209, 38);
            this.resultValueAddArrayBasedQueueLabel.Name = "resultValueAddArrayBasedQueueLabel";
            this.resultValueAddArrayBasedQueueLabel.Size = new System.Drawing.Size(46, 17);
            this.resultValueAddArrayBasedQueueLabel.TabIndex = 4;
            this.resultValueAddArrayBasedQueueLabel.Text = "empty";
            // 
            // runTestAddArrayBasedQueueButton
            // 
            this.runTestAddArrayBasedQueueButton.Location = new System.Drawing.Point(95, 262);
            this.runTestAddArrayBasedQueueButton.Name = "runTestAddArrayBasedQueueButton";
            this.runTestAddArrayBasedQueueButton.Size = new System.Drawing.Size(75, 23);
            this.runTestAddArrayBasedQueueButton.TabIndex = 3;
            this.runTestAddArrayBasedQueueButton.Text = "Run Test";
            this.runTestAddArrayBasedQueueButton.UseVisualStyleBackColor = true;
            this.runTestAddArrayBasedQueueButton.Click += new System.EventHandler(this.runTestAddArrayBasedQueueButton_Click);
            // 
            // resultAddLinkedListBasedQueueLabel
            // 
            this.resultAddLinkedListBasedQueueLabel.AutoSize = true;
            this.resultAddLinkedListBasedQueueLabel.Location = new System.Drawing.Point(32, 90);
            this.resultAddLinkedListBasedQueueLabel.Name = "resultAddLinkedListBasedQueueLabel";
            this.resultAddLinkedListBasedQueueLabel.Size = new System.Drawing.Size(109, 17);
            this.resultAddLinkedListBasedQueueLabel.TabIndex = 2;
            this.resultAddLinkedListBasedQueueLabel.Text = "Linked List Add:";
            // 
            // resultAddDynamicArrayBasedQueueLabel
            // 
            this.resultAddDynamicArrayBasedQueueLabel.AutoSize = true;
            this.resultAddDynamicArrayBasedQueueLabel.Location = new System.Drawing.Point(32, 64);
            this.resultAddDynamicArrayBasedQueueLabel.Name = "resultAddDynamicArrayBasedQueueLabel";
            this.resultAddDynamicArrayBasedQueueLabel.Size = new System.Drawing.Size(133, 17);
            this.resultAddDynamicArrayBasedQueueLabel.TabIndex = 2;
            this.resultAddDynamicArrayBasedQueueLabel.Text = "Dynamic Array Add:";
            // 
            // resultAddArrayBasedQueueLabel
            // 
            this.resultAddArrayBasedQueueLabel.AutoSize = true;
            this.resultAddArrayBasedQueueLabel.Location = new System.Drawing.Point(32, 38);
            this.resultAddArrayBasedQueueLabel.Name = "resultAddArrayBasedQueueLabel";
            this.resultAddArrayBasedQueueLabel.Size = new System.Drawing.Size(75, 17);
            this.resultAddArrayBasedQueueLabel.TabIndex = 2;
            this.resultAddArrayBasedQueueLabel.Text = "Array Add:";
            // 
            // stackAddGroupBox
            // 
            this.stackAddGroupBox.Controls.Add(this.resultValueRemoveEmbeddedStackBasedLabel);
            this.stackAddGroupBox.Controls.Add(this.resultValueRemoveLinkedListBasedStackLabel);
            this.stackAddGroupBox.Controls.Add(this.resultValueRemoveDynamicArrayBasedStackLabel);
            this.stackAddGroupBox.Controls.Add(this.resultRemoveEmbeddedBasedStackLabel);
            this.stackAddGroupBox.Controls.Add(this.resultValueRemoveArrayBasedStackLabel);
            this.stackAddGroupBox.Controls.Add(this.resultRemoveLinkedListBasedStackLabel);
            this.stackAddGroupBox.Controls.Add(this.resultRemoveDynamicArrayBasedStackLabel);
            this.stackAddGroupBox.Controls.Add(this.resultRemoveArrayBasedStackLabel);
            this.stackAddGroupBox.Controls.Add(this.resultValueAddEmbeddedStackBasedLabel);
            this.stackAddGroupBox.Controls.Add(this.resultValueAddLinkedListBasedStackLabel);
            this.stackAddGroupBox.Controls.Add(this.resultValueAddDynamicArrayBasedStackLabel);
            this.stackAddGroupBox.Controls.Add(this.resultAddEmbeddedBasedStackLabel);
            this.stackAddGroupBox.Controls.Add(this.resultValueAddArrayBasedStackLabel);
            this.stackAddGroupBox.Controls.Add(this.runTestAddArrayBasedStackButton);
            this.stackAddGroupBox.Controls.Add(this.resultAddLinkedListBasedStackLabel);
            this.stackAddGroupBox.Controls.Add(this.resultAddDynamicArrayBasedStackLabel);
            this.stackAddGroupBox.Controls.Add(this.resultAddArrayBasedStackLabel);
            this.stackAddGroupBox.Location = new System.Drawing.Point(9, 65);
            this.stackAddGroupBox.Name = "stackAddGroupBox";
            this.stackAddGroupBox.Size = new System.Drawing.Size(300, 300);
            this.stackAddGroupBox.TabIndex = 3;
            this.stackAddGroupBox.TabStop = false;
            this.stackAddGroupBox.Text = "Stack";
            // 
            // resultValueAddEmbeddedStackBasedLabel
            // 
            this.resultValueAddEmbeddedStackBasedLabel.AutoSize = true;
            this.resultValueAddEmbeddedStackBasedLabel.Location = new System.Drawing.Point(209, 117);
            this.resultValueAddEmbeddedStackBasedLabel.Name = "resultValueAddEmbeddedStackBasedLabel";
            this.resultValueAddEmbeddedStackBasedLabel.Size = new System.Drawing.Size(46, 17);
            this.resultValueAddEmbeddedStackBasedLabel.TabIndex = 4;
            this.resultValueAddEmbeddedStackBasedLabel.Text = "empty";
            // 
            // resultValueAddLinkedListBasedStackLabel
            // 
            this.resultValueAddLinkedListBasedStackLabel.AutoSize = true;
            this.resultValueAddLinkedListBasedStackLabel.Location = new System.Drawing.Point(209, 90);
            this.resultValueAddLinkedListBasedStackLabel.Name = "resultValueAddLinkedListBasedStackLabel";
            this.resultValueAddLinkedListBasedStackLabel.Size = new System.Drawing.Size(46, 17);
            this.resultValueAddLinkedListBasedStackLabel.TabIndex = 4;
            this.resultValueAddLinkedListBasedStackLabel.Text = "empty";
            this.resultValueAddLinkedListBasedStackLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // resultValueAddDynamicArrayBasedStackLabel
            // 
            this.resultValueAddDynamicArrayBasedStackLabel.AutoSize = true;
            this.resultValueAddDynamicArrayBasedStackLabel.Location = new System.Drawing.Point(209, 64);
            this.resultValueAddDynamicArrayBasedStackLabel.Name = "resultValueAddDynamicArrayBasedStackLabel";
            this.resultValueAddDynamicArrayBasedStackLabel.Size = new System.Drawing.Size(46, 17);
            this.resultValueAddDynamicArrayBasedStackLabel.TabIndex = 4;
            this.resultValueAddDynamicArrayBasedStackLabel.Text = "empty";
            // 
            // resultAddEmbeddedBasedStackLabel
            // 
            this.resultAddEmbeddedBasedStackLabel.AutoSize = true;
            this.resultAddEmbeddedBasedStackLabel.Location = new System.Drawing.Point(32, 117);
            this.resultAddEmbeddedBasedStackLabel.Name = "resultAddEmbeddedBasedStackLabel";
            this.resultAddEmbeddedBasedStackLabel.Size = new System.Drawing.Size(134, 17);
            this.resultAddEmbeddedBasedStackLabel.TabIndex = 2;
            this.resultAddEmbeddedBasedStackLabel.Text = "C # Embedded Add:";
            // 
            // resultValueAddArrayBasedStackLabel
            // 
            this.resultValueAddArrayBasedStackLabel.AutoSize = true;
            this.resultValueAddArrayBasedStackLabel.Location = new System.Drawing.Point(209, 38);
            this.resultValueAddArrayBasedStackLabel.Name = "resultValueAddArrayBasedStackLabel";
            this.resultValueAddArrayBasedStackLabel.Size = new System.Drawing.Size(46, 17);
            this.resultValueAddArrayBasedStackLabel.TabIndex = 4;
            this.resultValueAddArrayBasedStackLabel.Text = "empty";
            this.resultValueAddArrayBasedStackLabel.Click += new System.EventHandler(this.resultValueAddArrayBasedLabel_Click);
            // 
            // runTestAddArrayBasedStackButton
            // 
            this.runTestAddArrayBasedStackButton.Location = new System.Drawing.Point(95, 262);
            this.runTestAddArrayBasedStackButton.Name = "runTestAddArrayBasedStackButton";
            this.runTestAddArrayBasedStackButton.Size = new System.Drawing.Size(75, 23);
            this.runTestAddArrayBasedStackButton.TabIndex = 3;
            this.runTestAddArrayBasedStackButton.Text = "Run Test";
            this.runTestAddArrayBasedStackButton.UseVisualStyleBackColor = true;
            this.runTestAddArrayBasedStackButton.Click += new System.EventHandler(this.runTestAddArrayBasedButton_Click);
            // 
            // resultAddLinkedListBasedStackLabel
            // 
            this.resultAddLinkedListBasedStackLabel.AutoSize = true;
            this.resultAddLinkedListBasedStackLabel.Location = new System.Drawing.Point(32, 90);
            this.resultAddLinkedListBasedStackLabel.Name = "resultAddLinkedListBasedStackLabel";
            this.resultAddLinkedListBasedStackLabel.Size = new System.Drawing.Size(109, 17);
            this.resultAddLinkedListBasedStackLabel.TabIndex = 2;
            this.resultAddLinkedListBasedStackLabel.Text = "Linked List Add:";
            // 
            // resultAddDynamicArrayBasedStackLabel
            // 
            this.resultAddDynamicArrayBasedStackLabel.AutoSize = true;
            this.resultAddDynamicArrayBasedStackLabel.Location = new System.Drawing.Point(32, 64);
            this.resultAddDynamicArrayBasedStackLabel.Name = "resultAddDynamicArrayBasedStackLabel";
            this.resultAddDynamicArrayBasedStackLabel.Size = new System.Drawing.Size(133, 17);
            this.resultAddDynamicArrayBasedStackLabel.TabIndex = 2;
            this.resultAddDynamicArrayBasedStackLabel.Text = "Dynamic Array Add:";
            // 
            // resultAddArrayBasedStackLabel
            // 
            this.resultAddArrayBasedStackLabel.AutoSize = true;
            this.resultAddArrayBasedStackLabel.Location = new System.Drawing.Point(32, 38);
            this.resultAddArrayBasedStackLabel.Name = "resultAddArrayBasedStackLabel";
            this.resultAddArrayBasedStackLabel.Size = new System.Drawing.Size(75, 17);
            this.resultAddArrayBasedStackLabel.TabIndex = 2;
            this.resultAddArrayBasedStackLabel.Text = "Array Add:";
            this.resultAddArrayBasedStackLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // numberOfElemtsToAddAndRemovedLabel
            // 
            this.numberOfElemtsToAddAndRemovedLabel.AutoSize = true;
            this.numberOfElemtsToAddAndRemovedLabel.Location = new System.Drawing.Point(117, 32);
            this.numberOfElemtsToAddAndRemovedLabel.Name = "numberOfElemtsToAddAndRemovedLabel";
            this.numberOfElemtsToAddAndRemovedLabel.Size = new System.Drawing.Size(249, 17);
            this.numberOfElemtsToAddAndRemovedLabel.TabIndex = 1;
            this.numberOfElemtsToAddAndRemovedLabel.Text = "Number Of Elements To Add\\Remove:";
            this.numberOfElemtsToAddAndRemovedLabel.Click += new System.EventHandler(this.numberOfElemtsToAddLabel_Click);
            // 
            // numberOfElementsToAddTextBox
            // 
            this.numberOfElementsToAddTextBox.Location = new System.Drawing.Point(375, 29);
            this.numberOfElementsToAddTextBox.Name = "numberOfElementsToAddTextBox";
            this.numberOfElementsToAddTextBox.Size = new System.Drawing.Size(107, 22);
            this.numberOfElementsToAddTextBox.TabIndex = 0;
            this.numberOfElementsToAddTextBox.TextChanged += new System.EventHandler(this.numberOfElementsToAddTextBox_TextChanged);
            // 
            // resultValueRemoveEmbeddedStackBasedLabel
            // 
            this.resultValueRemoveEmbeddedStackBasedLabel.AutoSize = true;
            this.resultValueRemoveEmbeddedStackBasedLabel.Location = new System.Drawing.Point(209, 222);
            this.resultValueRemoveEmbeddedStackBasedLabel.Name = "resultValueRemoveEmbeddedStackBasedLabel";
            this.resultValueRemoveEmbeddedStackBasedLabel.Size = new System.Drawing.Size(46, 17);
            this.resultValueRemoveEmbeddedStackBasedLabel.TabIndex = 9;
            this.resultValueRemoveEmbeddedStackBasedLabel.Text = "empty";
            // 
            // resultValueRemoveLinkedListBasedStackLabel
            // 
            this.resultValueRemoveLinkedListBasedStackLabel.AutoSize = true;
            this.resultValueRemoveLinkedListBasedStackLabel.Location = new System.Drawing.Point(209, 195);
            this.resultValueRemoveLinkedListBasedStackLabel.Name = "resultValueRemoveLinkedListBasedStackLabel";
            this.resultValueRemoveLinkedListBasedStackLabel.Size = new System.Drawing.Size(46, 17);
            this.resultValueRemoveLinkedListBasedStackLabel.TabIndex = 10;
            this.resultValueRemoveLinkedListBasedStackLabel.Text = "empty";
            // 
            // resultValueRemoveDynamicArrayBasedStackLabel
            // 
            this.resultValueRemoveDynamicArrayBasedStackLabel.AutoSize = true;
            this.resultValueRemoveDynamicArrayBasedStackLabel.Location = new System.Drawing.Point(209, 169);
            this.resultValueRemoveDynamicArrayBasedStackLabel.Name = "resultValueRemoveDynamicArrayBasedStackLabel";
            this.resultValueRemoveDynamicArrayBasedStackLabel.Size = new System.Drawing.Size(46, 17);
            this.resultValueRemoveDynamicArrayBasedStackLabel.TabIndex = 11;
            this.resultValueRemoveDynamicArrayBasedStackLabel.Text = "empty";
            // 
            // resultRemoveEmbeddedBasedStackLabel
            // 
            this.resultRemoveEmbeddedBasedStackLabel.AutoSize = true;
            this.resultRemoveEmbeddedBasedStackLabel.Location = new System.Drawing.Point(32, 222);
            this.resultRemoveEmbeddedBasedStackLabel.Name = "resultRemoveEmbeddedBasedStackLabel";
            this.resultRemoveEmbeddedBasedStackLabel.Size = new System.Drawing.Size(161, 17);
            this.resultRemoveEmbeddedBasedStackLabel.TabIndex = 5;
            this.resultRemoveEmbeddedBasedStackLabel.Text = "C # Embedded Remove:";
            // 
            // resultValueRemoveArrayBasedStackLabel
            // 
            this.resultValueRemoveArrayBasedStackLabel.AutoSize = true;
            this.resultValueRemoveArrayBasedStackLabel.Location = new System.Drawing.Point(209, 143);
            this.resultValueRemoveArrayBasedStackLabel.Name = "resultValueRemoveArrayBasedStackLabel";
            this.resultValueRemoveArrayBasedStackLabel.Size = new System.Drawing.Size(46, 17);
            this.resultValueRemoveArrayBasedStackLabel.TabIndex = 12;
            this.resultValueRemoveArrayBasedStackLabel.Text = "empty";
            // 
            // resultRemoveLinkedListBasedStackLabel
            // 
            this.resultRemoveLinkedListBasedStackLabel.AutoSize = true;
            this.resultRemoveLinkedListBasedStackLabel.Location = new System.Drawing.Point(32, 195);
            this.resultRemoveLinkedListBasedStackLabel.Name = "resultRemoveLinkedListBasedStackLabel";
            this.resultRemoveLinkedListBasedStackLabel.Size = new System.Drawing.Size(136, 17);
            this.resultRemoveLinkedListBasedStackLabel.TabIndex = 6;
            this.resultRemoveLinkedListBasedStackLabel.Text = "Linked List Remove:";
            // 
            // resultRemoveDynamicArrayBasedStackLabel
            // 
            this.resultRemoveDynamicArrayBasedStackLabel.AutoSize = true;
            this.resultRemoveDynamicArrayBasedStackLabel.Location = new System.Drawing.Point(32, 169);
            this.resultRemoveDynamicArrayBasedStackLabel.Name = "resultRemoveDynamicArrayBasedStackLabel";
            this.resultRemoveDynamicArrayBasedStackLabel.Size = new System.Drawing.Size(160, 17);
            this.resultRemoveDynamicArrayBasedStackLabel.TabIndex = 7;
            this.resultRemoveDynamicArrayBasedStackLabel.Text = "Dynamic Array Remove:";
            // 
            // resultRemoveArrayBasedStackLabel
            // 
            this.resultRemoveArrayBasedStackLabel.AutoSize = true;
            this.resultRemoveArrayBasedStackLabel.Location = new System.Drawing.Point(32, 143);
            this.resultRemoveArrayBasedStackLabel.Name = "resultRemoveArrayBasedStackLabel";
            this.resultRemoveArrayBasedStackLabel.Size = new System.Drawing.Size(102, 17);
            this.resultRemoveArrayBasedStackLabel.TabIndex = 8;
            this.resultRemoveArrayBasedStackLabel.Text = "Array Remove:";
            // 
            // resultValueRemoveEmbeddedQueueBasedLabel
            // 
            this.resultValueRemoveEmbeddedQueueBasedLabel.AutoSize = true;
            this.resultValueRemoveEmbeddedQueueBasedLabel.Location = new System.Drawing.Point(209, 222);
            this.resultValueRemoveEmbeddedQueueBasedLabel.Name = "resultValueRemoveEmbeddedQueueBasedLabel";
            this.resultValueRemoveEmbeddedQueueBasedLabel.Size = new System.Drawing.Size(46, 17);
            this.resultValueRemoveEmbeddedQueueBasedLabel.TabIndex = 9;
            this.resultValueRemoveEmbeddedQueueBasedLabel.Text = "empty";
            // 
            // resultValueRemoveLinkedListBasedQueueLabel
            // 
            this.resultValueRemoveLinkedListBasedQueueLabel.AutoSize = true;
            this.resultValueRemoveLinkedListBasedQueueLabel.Location = new System.Drawing.Point(209, 195);
            this.resultValueRemoveLinkedListBasedQueueLabel.Name = "resultValueRemoveLinkedListBasedQueueLabel";
            this.resultValueRemoveLinkedListBasedQueueLabel.Size = new System.Drawing.Size(46, 17);
            this.resultValueRemoveLinkedListBasedQueueLabel.TabIndex = 10;
            this.resultValueRemoveLinkedListBasedQueueLabel.Text = "empty";
            // 
            // resultValueRemoveDynamicArrayBasedQueueLabel
            // 
            this.resultValueRemoveDynamicArrayBasedQueueLabel.AutoSize = true;
            this.resultValueRemoveDynamicArrayBasedQueueLabel.Location = new System.Drawing.Point(209, 169);
            this.resultValueRemoveDynamicArrayBasedQueueLabel.Name = "resultValueRemoveDynamicArrayBasedQueueLabel";
            this.resultValueRemoveDynamicArrayBasedQueueLabel.Size = new System.Drawing.Size(46, 17);
            this.resultValueRemoveDynamicArrayBasedQueueLabel.TabIndex = 11;
            this.resultValueRemoveDynamicArrayBasedQueueLabel.Text = "empty";
            // 
            // resultRemoveEmbeddedBasedQueueLabel
            // 
            this.resultRemoveEmbeddedBasedQueueLabel.AutoSize = true;
            this.resultRemoveEmbeddedBasedQueueLabel.Location = new System.Drawing.Point(32, 222);
            this.resultRemoveEmbeddedBasedQueueLabel.Name = "resultRemoveEmbeddedBasedQueueLabel";
            this.resultRemoveEmbeddedBasedQueueLabel.Size = new System.Drawing.Size(161, 17);
            this.resultRemoveEmbeddedBasedQueueLabel.TabIndex = 5;
            this.resultRemoveEmbeddedBasedQueueLabel.Text = "C # Embedded Remove:";
            // 
            // resultValueRemoveArrayBasedQueueLabel
            // 
            this.resultValueRemoveArrayBasedQueueLabel.AutoSize = true;
            this.resultValueRemoveArrayBasedQueueLabel.Location = new System.Drawing.Point(209, 143);
            this.resultValueRemoveArrayBasedQueueLabel.Name = "resultValueRemoveArrayBasedQueueLabel";
            this.resultValueRemoveArrayBasedQueueLabel.Size = new System.Drawing.Size(46, 17);
            this.resultValueRemoveArrayBasedQueueLabel.TabIndex = 12;
            this.resultValueRemoveArrayBasedQueueLabel.Text = "empty";
            // 
            // resultRemoveLinkedListBasedQueueLabel
            // 
            this.resultRemoveLinkedListBasedQueueLabel.AutoSize = true;
            this.resultRemoveLinkedListBasedQueueLabel.Location = new System.Drawing.Point(32, 195);
            this.resultRemoveLinkedListBasedQueueLabel.Name = "resultRemoveLinkedListBasedQueueLabel";
            this.resultRemoveLinkedListBasedQueueLabel.Size = new System.Drawing.Size(136, 17);
            this.resultRemoveLinkedListBasedQueueLabel.TabIndex = 6;
            this.resultRemoveLinkedListBasedQueueLabel.Text = "Linked List Remove:";
            // 
            // resultRemoveDynamicArrayBasedQueueLabel
            // 
            this.resultRemoveDynamicArrayBasedQueueLabel.AutoSize = true;
            this.resultRemoveDynamicArrayBasedQueueLabel.Location = new System.Drawing.Point(32, 169);
            this.resultRemoveDynamicArrayBasedQueueLabel.Name = "resultRemoveDynamicArrayBasedQueueLabel";
            this.resultRemoveDynamicArrayBasedQueueLabel.Size = new System.Drawing.Size(160, 17);
            this.resultRemoveDynamicArrayBasedQueueLabel.TabIndex = 7;
            this.resultRemoveDynamicArrayBasedQueueLabel.Text = "Dynamic Array Remove:";
            // 
            // resultRemoveArrayBasedQueueLabel
            // 
            this.resultRemoveArrayBasedQueueLabel.AutoSize = true;
            this.resultRemoveArrayBasedQueueLabel.Location = new System.Drawing.Point(32, 143);
            this.resultRemoveArrayBasedQueueLabel.Name = "resultRemoveArrayBasedQueueLabel";
            this.resultRemoveArrayBasedQueueLabel.Size = new System.Drawing.Size(102, 17);
            this.resultRemoveArrayBasedQueueLabel.TabIndex = 8;
            this.resultRemoveArrayBasedQueueLabel.Text = "Array Remove:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 529);
            this.Controls.Add(this.mainViewGroupBox);
            this.Name = "mainForm";
            this.Text = "Performance Tester";
            this.mainViewGroupBox.ResumeLayout(false);
            this.addAreaGroupBox.ResumeLayout(false);
            this.addAreaGroupBox.PerformLayout();
            this.queueAddGroupBox.ResumeLayout(false);
            this.queueAddGroupBox.PerformLayout();
            this.stackAddGroupBox.ResumeLayout(false);
            this.stackAddGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainViewGroupBox;
        private System.Windows.Forms.GroupBox addAreaGroupBox;
        private System.Windows.Forms.TextBox numberOfElementsToAddTextBox;
        private System.Windows.Forms.Label resultAddArrayBasedStackLabel;
        private System.Windows.Forms.Label numberOfElemtsToAddAndRemovedLabel;
        private System.Windows.Forms.GroupBox stackAddGroupBox;
        private System.Windows.Forms.Button runTestAddArrayBasedStackButton;
        private System.Windows.Forms.Label resultValueAddEmbeddedStackBasedLabel;
        private System.Windows.Forms.Label resultAddEmbeddedBasedStackLabel;
        private System.Windows.Forms.Label resultValueAddLinkedListBasedStackLabel;
        private System.Windows.Forms.Label resultAddLinkedListBasedStackLabel;
        private System.Windows.Forms.Label resultValueAddDynamicArrayBasedStackLabel;
        private System.Windows.Forms.Label resultAddDynamicArrayBasedStackLabel;
        private System.Windows.Forms.Label resultValueAddArrayBasedStackLabel;
        private System.Windows.Forms.GroupBox queueAddGroupBox;
        private System.Windows.Forms.Label resultValueAddEmbeddedQueueBasedLabel;
        private System.Windows.Forms.Label resultValueAddLinkedListBasedQueueLabel;
        private System.Windows.Forms.Label resultValueAddDynamicArrayBasedQueueLabel;
        private System.Windows.Forms.Label resultAddEmbeddedBasedQueueLabel;
        private System.Windows.Forms.Label resultValueAddArrayBasedQueueLabel;
        private System.Windows.Forms.Button runTestAddArrayBasedQueueButton;
        private System.Windows.Forms.Label resultAddLinkedListBasedQueueLabel;
        private System.Windows.Forms.Label resultAddDynamicArrayBasedQueueLabel;
        private System.Windows.Forms.Label resultAddArrayBasedQueueLabel;
        private System.Windows.Forms.Label resultValueRemoveEmbeddedQueueBasedLabel;
        private System.Windows.Forms.Label resultValueRemoveLinkedListBasedQueueLabel;
        private System.Windows.Forms.Label resultValueRemoveDynamicArrayBasedQueueLabel;
        private System.Windows.Forms.Label resultRemoveEmbeddedBasedQueueLabel;
        private System.Windows.Forms.Label resultValueRemoveArrayBasedQueueLabel;
        private System.Windows.Forms.Label resultRemoveLinkedListBasedQueueLabel;
        private System.Windows.Forms.Label resultRemoveDynamicArrayBasedQueueLabel;
        private System.Windows.Forms.Label resultRemoveArrayBasedQueueLabel;
        private System.Windows.Forms.Label resultValueRemoveEmbeddedStackBasedLabel;
        private System.Windows.Forms.Label resultValueRemoveLinkedListBasedStackLabel;
        private System.Windows.Forms.Label resultValueRemoveDynamicArrayBasedStackLabel;
        private System.Windows.Forms.Label resultRemoveEmbeddedBasedStackLabel;
        private System.Windows.Forms.Label resultValueRemoveArrayBasedStackLabel;
        private System.Windows.Forms.Label resultRemoveLinkedListBasedStackLabel;
        private System.Windows.Forms.Label resultRemoveDynamicArrayBasedStackLabel;
        private System.Windows.Forms.Label resultRemoveArrayBasedStackLabel;
    }
}

