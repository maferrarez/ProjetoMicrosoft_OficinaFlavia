   M S B A M L   `   `   `  ����I  EOficina_Flavia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Oficina_Flavia.ViewsOficina_Flavia.Views  5   	   /    )Oficina_Flavia.Views.frmCadastrarConserto   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Oficina_Flavia.Views     5   	     � Title$"  Oficina da Flavia - Conserto��5   	   $	��612��6.   $	��440��6;    � WindowStartupLocation$ CenterScreen=�6G   ���	#FF082321.��5	      � .+�5
   
   �� $��Conserto��6   $
��Left=�6#   $��
152,14,0,0q�6>   $	��Top=�6R   $��34��6j   $��Century725 Cn BT)�6v   $��24(�6�   
�������6�   �� 5   
   $��Funcionario��6   $
��Left=�6&   $��	81,68,0,0q�6A   $	��Top=�6T   
�������$��GeoSlab703 Md BT)�6   $��12(�6�   �� 5   
   -   5         ��Name$ cboFuncionario��5      $
��Left=�6+   $��
224,69,0,0q�6F   $	��Top=�6Z   $	��153��6r   $��0��6�   �� 5   
   $��Cliente��6   $
��Left=�6"   $��
93,107,0,0q�6=   $	��Top=�6Q   
�������$��GeoSlab703 Md BT)�6|   $��12(�6�   �� 5   
   -   5        $ 
cboCliente��5      $
��Left=�6'   $��224,113,0,0q�6B   $	��Top=�6W   $	��153��6o   $��1��6{   6�   �� 5   
   -   5         ��Name$ btnBuscarCarro��5      $��Buscar Carros��6)   $
��Left=�6A   $��265,156,0,0q�6\   $	��Top=�6q   6�   �� 5   
   $��Carros��6   $
��Left=�6!   $��
68,197,0,0q�6<   $	��Top=�6P    J� RenderTransformOrigin$ 0.954,2.848&�6h   $	��100��6�   $	��Top=�6�   $��Center=�6�   
�������$��GeoSlab703 Md BT)�6�   �� 5   
   -   5        $ 	cboCarros��5      $
��Left=�6&   $��224,197,0,0q�6A   $	��Top=�6V   $	��153��6n   $��2��6z   �� 5   
   $(��"Selecione os serviços realilzados��6   $
��Left=�6<   $��
18,242,0,0q�6W   $	��Top=�6k   $ 0.954,2.848&�6�   $	��199��6�   $	��Top=�6�   $��Center=�6�   
�������$��GeoSlab703 Md BT)�6	  �� 5   
   -   5        $ cboServicos��5      $
��Left=�6(   $��228,244,0,0q�6C   $	��Top=�6X   $	��149��6p   $��2��6�   �� 5   
   -   5        $ btnAdicionar��5      $��	Adicionar��6'   $
��Left=�6;   $��287,283,0,0q�6V   $	��Top=�6k   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtaServicos��5      $��
36,330,0,0q�6(   $	��328��6<      AutoGenerateColumns$ False��6H   $
��Left=�6d   $��Center=�6   $	��Top=�6�   $	��117��6�   $	��Top=�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nome��6>   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 1* 6L   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *Nome+6L     5      $ Descrição��6C   $	 1* 6V   
 6%   �� *	Descricao+6V     5      $ Valor��6?   $	 1* 6N   
 6%   �� *Valor+6N   5      �� 5   
   -   5         ��Name$ lblTotal��5      $��Total: ��6"   $
��Left=�64   $��200,452,0,0q�6O   $	��Top=�6d   $ 0.965,-1.18&�6|   $��GeoSlab703 Md BT)�6�   
�������$��13(�6�   (  "System.Windows.Controls.DatePicker  5   
   -	   5          Name$ 	dataSaida��5      $
��Left=�6(   $��254,486,0,0q�6C   $	��Top=�6X   �� 5   
   $)��#Data de finalização do conserto: ��6   $
��Left=�6<   $��
36,483,0,0q�6W   $	��Top=�6k   $	��199��6�   $��30��6�   
�������$��GeoSlab703 Md BT)�6�   $��12(�6�   �� 5   
   -
   5        $ btnLimparConserto��5      $��Limpar��6,   $
��Left=�6=   $��136,537,0,0q�6X   $	��Top=�6m   $��7��6�   $��Georgia)�6�   $��14(�6�   6�   �� 5    
   -   5        $ brnCadastrar��5       $��	Cadastrar��6'   $
��Left=�6;   $��236,537,0,0q�6V   $	��Top=�6k   $��Georgia)�6�   $��14(�6�   5"      5#      