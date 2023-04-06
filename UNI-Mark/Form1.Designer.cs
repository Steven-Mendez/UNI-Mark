namespace UNI_Mark
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            OSName = new Label();
            OperativeSystem = new GroupBox();
            OSVersion = new Label();
            ProcessorArchitecture = new Label();
            Processor = new GroupBox();
            ProcessorSpeed = new Label();
            ProcessorModel = new Label();
            Disk = new GroupBox();
            DiskType = new Label();
            DiskFreeSpace = new Label();
            RAM = new GroupBox();
            RAMCapacity = new Label();
            RAMSpeed = new Label();
            StartBenchmark = new Button();
            Result = new GroupBox();
            Elapsed = new Label();
            Score = new Label();
            Performance = new Label();
            ProgressBar = new ProgressBar();
            Credits = new GroupBox();
            Vilma = new Label();
            Steven = new Label();
            Jhon = new Label();
            Jeannette = new Label();
            BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            Cancel = new Button();
            OperativeSystem.SuspendLayout();
            Processor.SuspendLayout();
            Disk.SuspendLayout();
            RAM.SuspendLayout();
            Result.SuspendLayout();
            Credits.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(274, 9);
            label1.Name = "label1";
            label1.Size = new Size(253, 65);
            label1.TabIndex = 0;
            label1.Text = "UNI-Mark";
            // 
            // OSName
            // 
            OSName.AutoSize = true;
            OSName.Location = new Point(6, 19);
            OSName.Name = "OSName";
            OSName.Size = new Size(57, 15);
            OSName.TabIndex = 1;
            OSName.Text = "Nombre: ";
            // 
            // OperativeSystem
            // 
            OperativeSystem.Controls.Add(OSVersion);
            OperativeSystem.Controls.Add(OSName);
            OperativeSystem.Location = new Point(12, 77);
            OperativeSystem.Name = "OperativeSystem";
            OperativeSystem.Size = new Size(358, 69);
            OperativeSystem.TabIndex = 2;
            OperativeSystem.TabStop = false;
            OperativeSystem.Text = "Sistema Operativo";
            // 
            // OSVersion
            // 
            OSVersion.AutoSize = true;
            OSVersion.Location = new Point(6, 43);
            OSVersion.Name = "OSVersion";
            OSVersion.Size = new Size(51, 15);
            OSVersion.TabIndex = 2;
            OSVersion.Text = "Versión: ";
            // 
            // ProcessorArchitecture
            // 
            ProcessorArchitecture.AutoSize = true;
            ProcessorArchitecture.Location = new Point(6, 43);
            ProcessorArchitecture.Name = "ProcessorArchitecture";
            ProcessorArchitecture.Size = new Size(79, 15);
            ProcessorArchitecture.TabIndex = 3;
            ProcessorArchitecture.Text = "Arquitectura: ";
            // 
            // Processor
            // 
            Processor.Controls.Add(ProcessorSpeed);
            Processor.Controls.Add(ProcessorModel);
            Processor.Controls.Add(ProcessorArchitecture);
            Processor.Location = new Point(12, 166);
            Processor.Name = "Processor";
            Processor.Size = new Size(358, 100);
            Processor.TabIndex = 4;
            Processor.TabStop = false;
            Processor.Text = "Procesador";
            // 
            // ProcessorSpeed
            // 
            ProcessorSpeed.AutoSize = true;
            ProcessorSpeed.Location = new Point(6, 67);
            ProcessorSpeed.Name = "ProcessorSpeed";
            ProcessorSpeed.Size = new Size(158, 15);
            ProcessorSpeed.TabIndex = 5;
            ProcessorSpeed.Text = "Velocidad Máxima del Reloj: ";
            // 
            // ProcessorModel
            // 
            ProcessorModel.AutoSize = true;
            ProcessorModel.Location = new Point(6, 19);
            ProcessorModel.Name = "ProcessorModel";
            ProcessorModel.Size = new Size(54, 15);
            ProcessorModel.TabIndex = 4;
            ProcessorModel.Text = "Modelo: ";
            // 
            // Disk
            // 
            Disk.Controls.Add(DiskType);
            Disk.Controls.Add(DiskFreeSpace);
            Disk.Location = new Point(12, 286);
            Disk.Name = "Disk";
            Disk.Size = new Size(358, 67);
            Disk.TabIndex = 6;
            Disk.TabStop = false;
            Disk.Text = "Almacenamiento Principal";
            // 
            // DiskType
            // 
            DiskType.AutoSize = true;
            DiskType.Location = new Point(6, 19);
            DiskType.Name = "DiskType";
            DiskType.Size = new Size(36, 15);
            DiskType.TabIndex = 4;
            DiskType.Text = "Tipo: ";
            // 
            // DiskFreeSpace
            // 
            DiskFreeSpace.AutoSize = true;
            DiskFreeSpace.Location = new Point(6, 43);
            DiskFreeSpace.Name = "DiskFreeSpace";
            DiskFreeSpace.Size = new Size(112, 15);
            DiskFreeSpace.TabIndex = 3;
            DiskFreeSpace.Text = "Espacio Disponible: ";
            // 
            // RAM
            // 
            RAM.Controls.Add(RAMCapacity);
            RAM.Controls.Add(RAMSpeed);
            RAM.Location = new Point(12, 373);
            RAM.Name = "RAM";
            RAM.Size = new Size(358, 64);
            RAM.TabIndex = 6;
            RAM.TabStop = false;
            RAM.Text = "RAM";
            // 
            // RAMCapacity
            // 
            RAMCapacity.AutoSize = true;
            RAMCapacity.Location = new Point(6, 19);
            RAMCapacity.Name = "RAMCapacity";
            RAMCapacity.Size = new Size(69, 15);
            RAMCapacity.TabIndex = 4;
            RAMCapacity.Text = "Capacidad: ";
            // 
            // RAMSpeed
            // 
            RAMSpeed.AutoSize = true;
            RAMSpeed.Location = new Point(6, 43);
            RAMSpeed.Name = "RAMSpeed";
            RAMSpeed.Size = new Size(64, 15);
            RAMSpeed.TabIndex = 3;
            RAMSpeed.Text = "Velocidad: ";
            // 
            // StartBenchmark
            // 
            StartBenchmark.AutoSize = true;
            StartBenchmark.Location = new Point(538, 329);
            StartBenchmark.Name = "StartBenchmark";
            StartBenchmark.Size = new Size(112, 25);
            StartBenchmark.TabIndex = 7;
            StartBenchmark.Text = "Iniciar Benchmark";
            StartBenchmark.UseVisualStyleBackColor = true;
            StartBenchmark.Click += StartBenchmark_Click;
            // 
            // Result
            // 
            Result.Controls.Add(Elapsed);
            Result.Controls.Add(Score);
            Result.Controls.Add(Performance);
            Result.Location = new Point(418, 201);
            Result.Name = "Result";
            Result.Size = new Size(370, 100);
            Result.TabIndex = 6;
            Result.TabStop = false;
            Result.Text = "Resultado";
            // 
            // Elapsed
            // 
            Elapsed.AutoSize = true;
            Elapsed.Location = new Point(5, 67);
            Elapsed.Name = "Elapsed";
            Elapsed.Size = new Size(121, 15);
            Elapsed.TabIndex = 5;
            Elapsed.Text = "Tiempo Transcurrido: ";
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.Location = new Point(6, 19);
            Score.Name = "Score";
            Score.Size = new Size(53, 15);
            Score.TabIndex = 4;
            Score.Text = "Puntaje: ";
            // 
            // Performance
            // 
            Performance.AutoSize = true;
            Performance.Location = new Point(6, 43);
            Performance.Name = "Performance";
            Performance.Size = new Size(81, 15);
            Performance.TabIndex = 3;
            Performance.Text = "Rendimiento: ";
            // 
            // ProgressBar
            // 
            ProgressBar.Location = new Point(418, 414);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(370, 23);
            ProgressBar.TabIndex = 8;
            // 
            // Credits
            // 
            Credits.Controls.Add(Vilma);
            Credits.Controls.Add(Steven);
            Credits.Controls.Add(Jhon);
            Credits.Controls.Add(Jeannette);
            Credits.Location = new Point(418, 77);
            Credits.Name = "Credits";
            Credits.Size = new Size(370, 118);
            Credits.TabIndex = 7;
            Credits.TabStop = false;
            Credits.Text = "Creditos";
            // 
            // Vilma
            // 
            Vilma.AutoSize = true;
            Vilma.Location = new Point(6, 89);
            Vilma.Name = "Vilma";
            Vilma.Size = new Size(244, 15);
            Vilma.TabIndex = 6;
            Vilma.Text = "- Vilma Milagros López Mendoza 2019-0053U";
            // 
            // Steven
            // 
            Steven.AutoSize = true;
            Steven.Location = new Point(6, 67);
            Steven.Name = "Steven";
            Steven.Size = new Size(242, 15);
            Steven.TabIndex = 5;
            Steven.Text = "- Steven Alexander Méndez Paiz. 2019-0048U";
            // 
            // Jhon
            // 
            Jhon.AutoSize = true;
            Jhon.Location = new Point(6, 43);
            Jhon.Name = "Jhon";
            Jhon.Size = new Size(226, 15);
            Jhon.TabIndex = 4;
            Jhon.Text = "- Jhon Kelvin Cerna Barahona 2019-0025U";
            // 
            // Jeannette
            // 
            Jeannette.AutoSize = true;
            Jeannette.Location = new Point(6, 19);
            Jeannette.Name = "Jeannette";
            Jeannette.Size = new Size(261, 15);
            Jeannette.TabIndex = 3;
            Jeannette.Text = "- Jeannette del Carmen López López 2019-0038U";
            // 
            // BackgroundWorker
            // 
            BackgroundWorker.WorkerReportsProgress = true;
            BackgroundWorker.WorkerSupportsCancellation = true;
            // 
            // Cancel
            // 
            Cancel.AutoSize = true;
            Cancel.Enabled = false;
            Cancel.Location = new Point(538, 360);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(112, 25);
            Cancel.TabIndex = 9;
            Cancel.Text = "Cancelar";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cancel);
            Controls.Add(Credits);
            Controls.Add(ProgressBar);
            Controls.Add(Result);
            Controls.Add(StartBenchmark);
            Controls.Add(RAM);
            Controls.Add(Disk);
            Controls.Add(Processor);
            Controls.Add(label1);
            Controls.Add(OperativeSystem);
            Name = "Form1";
            Text = "Form1";
            Shown += Form1_Shown;
            OperativeSystem.ResumeLayout(false);
            OperativeSystem.PerformLayout();
            Processor.ResumeLayout(false);
            Processor.PerformLayout();
            Disk.ResumeLayout(false);
            Disk.PerformLayout();
            RAM.ResumeLayout(false);
            RAM.PerformLayout();
            Result.ResumeLayout(false);
            Result.PerformLayout();
            Credits.ResumeLayout(false);
            Credits.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label OSName;
        private GroupBox OperativeSystem;
        private Label OSVersion;
        private Label ProcessorArchitecture;
        private GroupBox Processor;
        private Label ProcessorSpeed;
        private Label ProcessorModel;
        private GroupBox Disk;
        private Label DiskType;
        private Label DiskFreeSpace;
        private GroupBox RAM;
        private Label RAMCapacity;
        private Label RAMSpeed;
        private Button StartBenchmark;
        private GroupBox Result;
        private Label Elapsed;
        private Label Score;
        private Label Performance;
        private ProgressBar ProgressBar;
        private GroupBox Credits;
        private Label Vilma;
        private Label Steven;
        private Label Jhon;
        private Label Jeannette;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private Button Cancel;
    }
}