   M S B A M L   `   `   `  ����I  EOficina_Flavia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Oficina_Flavia.ViewsOficina_Flavia.Views  5   	   .    (Oficina_Flavia.Views.frmCadastrarCliente   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Oficina_Flavia.Views     5   	     � Title$!  Oficina da Flavia - Cliente��5   
   $	��410��6.   $	��326��6;    � WindowStartupLocation$ CenterScreen=�6G   ���	#FF082321.��5	      � .+�5
   
   �� $��Clientes��6   $
��Left=�6#   $��
106,10,0,0q�6>   $	��Top=�6R   $��Century725 Cn BT)�6j   $��26(�6�   
�������6�   �� 5   
   $
��Nome��6   $
��Left=�6   $��	25,99,0,0q�6:   $	��Top=�6M   
�������$��GeoSlab703 Md BT)�6x   �� 5   
   -   5         ��Name$ txtNome��5      $
��Left=�6#   $��100,103,0,0q�6>    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��180��6   $��0��6�   $��Segoe UI Semilight)�6�   �� 5   
   $	��CPF��6   $
��Left=�6   $��
25,166,0,0q�69   $	��Top=�6M   
�������$��GeoSlab703 Md BT)�6x   �� 5   
   -   5        $ txtCpf��5      $
��Left=�6"   $��100,170,0,0q�6=   $
 Wrap=�6R   $	��Top=�6f   $	��180��6~   $��1��6�   $��Segoe UI Semilight)�6�   �� 5   
   $��	Endereço��6   $
��Left=�6#   $��
25,197,0,0q�6>   $	��Top=�6R   
�������$��GeoSlab703 Md BT)�6}   �� 5   
   -   5        $ txtEndereco��5      $
��Left=�6'   $��100,198,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��180��6�   $��2��6�   $��Segoe UI Semilight)�6�   �� 5   
   $��Telefone��6   $
��Left=�6#   $��
25,228,0,0q�6>   $	��Top=�6R   
�������$��GeoSlab703 Md BT)�6}   �� 5   
   -   5        $ txtTelefone��5      $
��Left=�6'   $��100,232,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��180��6�   $��3��6�   $��Segoe UI Semilight)�6�   �� 5   
   $��E-mail��6   $
��Left=�6!   $��
25,259,0,0q�6<   $	��Top=�6P   
�������$��GeoSlab703 Md BT)�6{   �� 5   
   -   5        $ txtEmail��5      $
��Left=�6$   $��100,263,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $	��180��6�   $��4��6�   $��Segoe UI Semilight)�6�   �� 5   
   $��ID��6   $
��Left=�6   $��	25,65,0,0q�68   $	��Top=�6K   
�������$��GeoSlab703 Md BT)�6v   �� 5   
   -   5        $ txtId��5      $
��Left=�6!   $��
100,69,0,0q�6<   $
 Wrap=�6P   $	��Top=�6d   $	��180��6|   ${�False��6�   $��Segoe UI Semilight)�6�   �� 5   
   $��	Criado Em��6   $
��Left=�6$   $��
25,290,0,0q�6?   $	��Top=�6S   
�������$��GeoSlab703 Md BT)�6~   �� 5   
   -   5        $ txtDate��5      $
��Left=�6#   $��100,294,0,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $	��180��6   $��4��6�   ${�False��6�   $��Segoe UI Semilight)�6�   �� 5   
   -   5         ��Name$ btnCadastrarCliente��5      $��0,0,0,0q�6.   $��	Cadastrar��6@   $
��Left=�6T   $��237,329,0,0q�6o   $��Georgia)�6�   $��13(�6�   $��17��6�   $	��Top=�6�   �� 5   
   -	   5        $ btnBuscarCliente��5      $��0,0,0,0q�6+   $��Buscar��6=   $
��Left=�6N   $��189,329,0,0q�6i   $��Georgia)�6�   $��13(�6�   $��17��6�   $	��Top=�6�   �� 5   
   -
   5        $ btnLimparCliente��5      $��0,0,0,0q�6+   $��Limpar��6=   $��135,329,0,0q�6N   $��Georgia)�6�   $��13(�6�   $
��Left=�6�   $��44��6�   $��17��6�   $	��Top=�6�   �� 5   
   -   5        $ btnAlterarCliente��5      $��0,0,0,0q�6,   $��Alterar��6>   $
��Left=�6P   $��
88,329,0,0q�6k   $	��Top=�6   ${�False��6�   $��Georgia)�6�   $��13(�6�   �� 5   
   -   5        $ btnRemoverCliente��5      $��0,0,0,0q�6,   $��Remover��6>   $
��Left=�6P   $��
25,329,0,0q�6k   $	��Top=�6   ${�False��6�   $��Georgia)�6�   $��13(�6�   �� 5   
   $��	Sobrenome��6   $
��Left=�6$   $��
25,135,0,0q�6?   $	��Top=�6S   
�������$��GeoSlab703 Md BT)�6~   �� 5   
   -   5        $ txtSobrenome��5      $
��Left=�6(   $��100,139,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��180��6�   $��0��6�   $��Segoe UI Semilight)�6�   5!      5"      