   M S B A M L   `   `   `  ����I  EOficina_Flavia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Oficina_Flavia.ViewsOficina_Flavia.Views  5   	   2    ,Oficina_Flavia.Views.frmCadastrarFuncionario   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Oficina_Flavia.Views     5   	     � Title$&   Oficina da Flavia - Funcionarios��5   
   $	��360��63   $	��300��6@    � WindowStartupLocation$ CenterScreen=�6L   ���	#FF082321.��5	      � .+�5
   
   �� $��Funcionários��6   $��Center=�6'   $��0,10,0,0q�6D   $	��Top=�6V   $��Century725 Cn BT)�6n   $��26(�6�   
�������6�   �� 5   
   $
��Nome��6   $
��Left=�6   $��	17,95,0,0q�6:   $	��Top=�6M   
�������$��GeoSlab703 Md BT)�6x   �� 5   
   -   5         ��Name$ txtNome��5      $
��Left=�6#   $��	97,98,0,0q�6>    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��183��6}   $��0��6�   $��Segoe UI Semilight)�6�   �� 5   
   $	��CPF��6   $
��Left=�6   $��
17,129,0,0q�69   $	��Top=�6M   
�������$��GeoSlab703 Md BT)�6x   �� 5   
   -   5        $ txtCpf��5      $
��Left=�6"   $��
97,129,0,0q�6=   $
 Wrap=�6Q   $	��Top=�6e   $	��183��6}   $��1��6�   $��Segoe UI Semilight)�6�   �� 5   
   $��	Endereço��6   $
��Left=�6#   $��
17,157,0,0q�6>   $	��Top=�6R   
�������$��GeoSlab703 Md BT)�6}   �� 5   
   -   5        $ txtEndereco��5      $
��Left=�6'   $��
97,160,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $	��183��6�   $��2��6�   $��Segoe UI Semilight)�6�   �� 5   
   $��Telefone��6   $
��Left=�6#   $��
17,190,0,0q�6>   $	��Top=�6R   
�������$��GeoSlab703 Md BT)�6}   �� 5   
   -   5        $ txtTelefone��5      $
��Left=�6'   $��
97,193,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $	��183��6�   $��3��6�   $��Segoe UI Semilight)�6�   �� 5   
   $��Cargo��6   $
��Left=�6    $��
17,223,0,0q�6;   $	��Top=�6O   
�������$��GeoSlab703 Md BT)�6z   �� 5   
   -   5        $ txtCargo��5      $
��Left=�6$   $��
97,226,0,0q�6?   $
 Wrap=�6S   $	��Top=�6g   $	��183��6   $��4��6�   $��Segoe UI Semilight)�6�   �� 5   
   -   5         ��Name$ btnCadastrarFuncionario��5   m   $��	Cadastrar��6   $
��Left=�6%   $��225,300,0,0q�6@   $	��Top=�6U   $��5��6�   $��Georgia)�6�   $��13(�6�   �� 5   
   $��ID��6   $
��Left=�6   $��	17,64,0,0q�68   $	��Top=�6K   
�������$��GeoSlab703 Md BT)�6v   �� 5   
   -   5        $ txtId��5      $
��Left=�6!   $��	97,67,0,0q�6<   $
 Wrap=�6O   $	��Top=�6c   $	��183��6{   ${�False��6�   $��Segoe UI Semilight)�6�   �� 5   
   $��	Criado em��6   $
��Left=�6$   $��
17,255,0,0q�6?   $	��Top=�6S   
�������$��GeoSlab703 Md BT)�6~   �� 5   
   -   5        $ txtCriadoEm��5      $
��Left=�6'   $��
97,259,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $	��183��6�   ${�False��6�   $��Segoe UI Semilight)�6�   �� 5   
   -	   5        $ btnBuscarFuncionario��5      $��Buscar��6/   $
��Left=�6@   $��178,300,0,0q�6[   $	��Top=�6p   $��6��6�   $��Georgia)�6�   $��13(�6�   �� 5   
   -
   5        $ btnLimparFuncionario��5      $��Limpar��6/   $
��Left=�6@   $��127,300,0,0q�6[   $	��Top=�6p   $��7��6�   $��Georgia)�6�   $��13(�6�   �� 5   
   -   5        $ btnAlterarFuncionario��5      $��Alterar��60   $
��Left=�6B   $��
77,300,0,0q�6]   $	��Top=�6q   $��8��6�   $��Georgia)�6�   $��13(�6�   �� 5   
   -   5        $ btnRemoverFuncionario��5      $��Remover��60   $
��Left=�6B   $��
17,300,0,0q�6]   $	��Top=�6q   $��9��6�   $��Georgia)�6�   $��13(�6�   5      5      