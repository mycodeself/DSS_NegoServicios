#pragma once

namespace PruebaInterfaz {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for UI_Principal
	/// </summary>
	public ref class UI_Principal : public System::Windows::Forms::Form
	{
	public:
		UI_Principal(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~UI_Principal()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::SplitContainer^  splitContainer1;
	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::Button^  Crear_usuario;


	private: System::Windows::Forms::Label^  gestion_reservas_label;
	private: System::Windows::Forms::Label^  gestion_usuarios_label;
	private: System::Windows::Forms::Button^  Modificar_proyecto;
	private: System::Windows::Forms::Button^  button3;
	private: System::Windows::Forms::Button^  button2;
	private: System::Windows::Forms::Button^  button5;
	private: System::Windows::Forms::Button^  button4;




	protected:

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->splitContainer1 = (gcnew System::Windows::Forms::SplitContainer());
			this->button3 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->Modificar_proyecto = (gcnew System::Windows::Forms::Button());
			this->gestion_usuarios_label = (gcnew System::Windows::Forms::Label());
			this->Crear_usuario = (gcnew System::Windows::Forms::Button());
			this->gestion_reservas_label = (gcnew System::Windows::Forms::Label());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->button4 = (gcnew System::Windows::Forms::Button());
			this->button5 = (gcnew System::Windows::Forms::Button());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->splitContainer1))->BeginInit();
			this->splitContainer1->Panel1->SuspendLayout();
			this->splitContainer1->Panel2->SuspendLayout();
			this->splitContainer1->SuspendLayout();
			this->SuspendLayout();
			// 
			// splitContainer1
			// 
			this->splitContainer1->Dock = System::Windows::Forms::DockStyle::Fill;
			this->splitContainer1->Location = System::Drawing::Point(0, 0);
			this->splitContainer1->Name = L"splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this->splitContainer1->Panel1->Controls->Add(this->button3);
			this->splitContainer1->Panel1->Controls->Add(this->button2);
			this->splitContainer1->Panel1->Controls->Add(this->Modificar_proyecto);
			this->splitContainer1->Panel1->Controls->Add(this->gestion_usuarios_label);
			this->splitContainer1->Panel1->Controls->Add(this->Crear_usuario);
			this->splitContainer1->Panel1->Paint += gcnew System::Windows::Forms::PaintEventHandler(this, &UI_Principal::splitContainer1_Panel1_Paint);
			// 
			// splitContainer1.Panel2
			// 
			this->splitContainer1->Panel2->Controls->Add(this->button5);
			this->splitContainer1->Panel2->Controls->Add(this->button4);
			this->splitContainer1->Panel2->Controls->Add(this->gestion_reservas_label);
			this->splitContainer1->Panel2->Controls->Add(this->button1);
			this->splitContainer1->Panel2->Paint += gcnew System::Windows::Forms::PaintEventHandler(this, &UI_Principal::splitContainer1_Panel2_Paint);
			this->splitContainer1->Size = System::Drawing::Size(539, 318);
			this->splitContainer1->SplitterDistance = 241;
			this->splitContainer1->TabIndex = 0;
			// 
			// button3
			// 
			this->button3->Location = System::Drawing::Point(73, 192);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(102, 42);
			this->button3->TabIndex = 6;
			this->button3->Text = L"Buscar Cliente";
			this->button3->UseVisualStyleBackColor = true;
			this->button3->Click += gcnew System::EventHandler(this, &UI_Principal::button3_Click);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(73, 144);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(102, 42);
			this->button2->TabIndex = 5;
			this->button2->Text = L"Borrar Cliente";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &UI_Principal::button2_Click);
			// 
			// Modificar_proyecto
			// 
			this->Modificar_proyecto->Location = System::Drawing::Point(73, 96);
			this->Modificar_proyecto->Name = L"Modificar_proyecto";
			this->Modificar_proyecto->Size = System::Drawing::Size(102, 42);
			this->Modificar_proyecto->TabIndex = 4;
			this->Modificar_proyecto->Text = L"Modificar Cliente";
			this->Modificar_proyecto->UseVisualStyleBackColor = true;
			this->Modificar_proyecto->Click += gcnew System::EventHandler(this, &UI_Principal::Modificar_proyecto_Click);
			// 
			// gestion_usuarios_label
			// 
			this->gestion_usuarios_label->AutoSize = true;
			this->gestion_usuarios_label->Location = System::Drawing::Point(70, 9);
			this->gestion_usuarios_label->Name = L"gestion_usuarios_label";
			this->gestion_usuarios_label->Size = System::Drawing::Size(114, 13);
			this->gestion_usuarios_label->TabIndex = 3;
			this->gestion_usuarios_label->Text = L"GESTION USUARIOS";
			// 
			// Crear_usuario
			// 
			this->Crear_usuario->Location = System::Drawing::Point(73, 48);
			this->Crear_usuario->Name = L"Crear_usuario";
			this->Crear_usuario->Size = System::Drawing::Size(102, 42);
			this->Crear_usuario->TabIndex = 0;
			this->Crear_usuario->Text = L"Crear Usuario";
			this->Crear_usuario->UseVisualStyleBackColor = true;
			this->Crear_usuario->Click += gcnew System::EventHandler(this, &UI_Principal::Crear_usuario_Click);
			// 
			// gestion_reservas_label
			// 
			this->gestion_reservas_label->AutoSize = true;
			this->gestion_reservas_label->Location = System::Drawing::Point(85, 9);
			this->gestion_reservas_label->Name = L"gestion_reservas_label";
			this->gestion_reservas_label->Size = System::Drawing::Size(105, 13);
			this->gestion_reservas_label->TabIndex = 2;
			this->gestion_reservas_label->Text = L"GESTION SISTEMA";
			this->gestion_reservas_label->Click += gcnew System::EventHandler(this, &UI_Principal::label2_Click);
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(88, 48);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(90, 42);
			this->button1->TabIndex = 0;
			this->button1->Text = L"Gestionar Reservas";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &UI_Principal::button1_Click);
			// 
			// button4
			// 
			this->button4->Location = System::Drawing::Point(88, 96);
			this->button4->Name = L"button4";
			this->button4->Size = System::Drawing::Size(90, 42);
			this->button4->TabIndex = 3;
			this->button4->Text = L"Gestionar Aerolineas";
			this->button4->UseVisualStyleBackColor = true;
			this->button4->Click += gcnew System::EventHandler(this, &UI_Principal::button4_Click);
			// 
			// button5
			// 
			this->button5->Location = System::Drawing::Point(88, 144);
			this->button5->Name = L"button5";
			this->button5->Size = System::Drawing::Size(90, 42);
			this->button5->TabIndex = 4;
			this->button5->Text = L"Gestionar Vuelos";
			this->button5->UseVisualStyleBackColor = true;
			this->button5->Click += gcnew System::EventHandler(this, &UI_Principal::button5_Click);
			// 
			// UI_Principal
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(539, 318);
			this->Controls->Add(this->splitContainer1);
			this->Name = L"UI_Principal";
			this->Text = L"Interfaz Empleado";
			this->splitContainer1->Panel1->ResumeLayout(false);
			this->splitContainer1->Panel1->PerformLayout();
			this->splitContainer1->Panel2->ResumeLayout(false);
			this->splitContainer1->Panel2->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->splitContainer1))->EndInit();
			this->splitContainer1->ResumeLayout(false);
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void splitContainer1_Panel1_Paint(System::Object^  sender, System::Windows::Forms::PaintEventArgs^  e) {
	}
	private: System::Void splitContainer1_Panel2_Paint(System::Object^  sender, System::Windows::Forms::PaintEventArgs^  e) {
	}
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
	}
	private: System::Void label2_Click(System::Object^  sender, System::EventArgs^  e) {
	}
private: System::Void Crear_usuario_Click(System::Object^  sender, System::EventArgs^  e) {

}
private: System::Void Modificar_proyecto_Click(System::Object^  sender, System::EventArgs^  e) {
}
private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e) {
}
private: System::Void button3_Click(System::Object^  sender, System::EventArgs^  e) {
}
private: System::Void button4_Click(System::Object^  sender, System::EventArgs^  e) {
}
private: System::Void button5_Click(System::Object^  sender, System::EventArgs^  e) {
}
};
}
