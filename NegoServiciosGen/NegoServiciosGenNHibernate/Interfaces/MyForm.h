#pragma once

#include "Interfaz_Empleado.h"

namespace PruebaInterfaz {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
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
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TextBox^  textBox1;
	private: System::Windows::Forms::TextBox^  textBox2;
	private: System::Windows::Forms::Label^  Usuario;
	private: System::Windows::Forms::Label^  Contraseña;
	private: System::Windows::Forms::Label^  IU_nombre;
	private: System::Windows::Forms::Button^  Entrar;


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
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->Usuario = (gcnew System::Windows::Forms::Label());
			this->Contraseña = (gcnew System::Windows::Forms::Label());
			this->IU_nombre = (gcnew System::Windows::Forms::Label());
			this->Entrar = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(118, 74);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(143, 20);
			this->textBox1->TabIndex = 0;
			this->textBox1->TextChanged += gcnew System::EventHandler(this, &MyForm::textBox1_TextChanged);
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(118, 111);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(143, 20);
			this->textBox2->TabIndex = 1;
			// 
			// Usuario
			// 
			this->Usuario->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->Usuario->Location = System::Drawing::Point(12, 74);
			this->Usuario->Name = L"Usuario";
			this->Usuario->Size = System::Drawing::Size(100, 20);
			this->Usuario->TabIndex = 2;
			this->Usuario->Text = L"Usuario";
			this->Usuario->Click += gcnew System::EventHandler(this, &MyForm::label1_Click);
			// 
			// Contraseña
			// 
			this->Contraseña->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->Contraseña->Location = System::Drawing::Point(12, 111);
			this->Contraseña->Name = L"Contraseña";
			this->Contraseña->Size = System::Drawing::Size(97, 20);
			this->Contraseña->TabIndex = 3;
			this->Contraseña->Text = L"Contraseña";
			this->Contraseña->Click += gcnew System::EventHandler(this, &MyForm::label1_Click_1);
			// 
			// IU_nombre
			// 
			this->IU_nombre->Location = System::Drawing::Point(54, 9);
			this->IU_nombre->Name = L"IU_nombre";
			this->IU_nombre->Size = System::Drawing::Size(143, 33);
			this->IU_nombre->TabIndex = 4;
			this->IU_nombre->Text = L"NEGOSERVICIOS LOGIN";
			// 
			// Entrar
			// 
			this->Entrar->Location = System::Drawing::Point(15, 192);
			this->Entrar->Name = L"Entrar";
			this->Entrar->Size = System::Drawing::Size(75, 23);
			this->Entrar->TabIndex = 5;
			this->Entrar->Text = L"Entrar";
			this->Entrar->UseVisualStyleBackColor = true;
			this->Entrar->Click += gcnew System::EventHandler(this, &MyForm::Entrar_Click);
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(304, 245);
			this->Controls->Add(this->Entrar);
			this->Controls->Add(this->IU_nombre);
			this->Controls->Add(this->Contraseña);
			this->Controls->Add(this->Usuario);
			this->Controls->Add(this->textBox2);
			this->Controls->Add(this->textBox1);
			this->Name = L"MyForm";
			this->Text = L"NEGOSERVICOS";
			this->Load += gcnew System::EventHandler(this, &MyForm::MyForm_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void MyForm_Load(System::Object^  sender, System::EventArgs^  e) {
	}
	private: System::Void textBox1_TextChanged(System::Object^  sender, System::EventArgs^  e) {
	}
	private: System::Void label1_Click(System::Object^  sender, System::EventArgs^  e) {
	}
	private: System::Void label1_Click_1(System::Object^  sender, System::EventArgs^  e) {
	}
private: System::Void Entrar_Click(System::Object^  sender, System::EventArgs^  e) {
	PruebaInterfaz::UI_Principal form;
	form.ShowDialog();
}
};
}
