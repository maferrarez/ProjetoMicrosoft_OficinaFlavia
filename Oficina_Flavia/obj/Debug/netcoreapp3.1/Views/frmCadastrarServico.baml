   M S B A M L   `   `   `  ����I  EOficina_Flavia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Oficina_Flavia.ViewsOficina_Flavia.Views  5   	   .    (Oficina_Flavia.Views.frmCadastrarServico   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Oficina_Flavia.Views     5   	     � Title$#  Oficina da Flavia - Serviços��5   	   $	��320��6.   $	��300��6;    � WindowStartupLocation$ CenterScreen=�6G   $��10,10,10,10q�6l   $��16(�6�   $��Medium&�6�   $	��Top=�6�   $��Center=�6�   $��Center=�6�   $��Center=�6�   ���	#FF082321.��5	      � .+�5
   
   �� $��	Serviços��6   $
��Left=�6#   $	��Top=�6>    J� RenderTransformOrigin$ 0.479,0.609&�6V   $��Century751 No2 BT)�6z   $��27(�6�   
�������$��	95,14,0,0q�6�   �� 5   
   -   5         ��Name$ txtId��5      $
��Left=�6!   $��
113,88,0,0q�6<    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��155��6|   ${�False��6�   $��22��6�   $��Segoe UI Semilight)�6�   $��12(�6�   �� 5   
   $
��ID: ��6   $
��Left=�6   $��	22,86,0,0q�6:   $	��Top=�6M   $��GeoSlab703 Md BT)�6e   $��12(�6�   $��Normal&�6�   $��Normal$�6�   
�������6�   �� 5   
   $��Nome:��6   $
��Left=�6    $��
22,117,0,0q�6;   $	��Top=�6O   $��GeoSlab703 Md BT)�6g   $��12(�6�   $��Normal&�6�   $��Normal$�6�   
�������6�   �� 5   
   -   5        $ txtNome��5      $
��Left=�6#   $��113,117,0,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $	��155��6   $��0��6�   $��22��6�   $��Segoe UI Semilight)�6�   $��12(�6�   �� 5   
   $��Descrição:��6   $
��Left=�6%   $��
22,145,0,0q�6@   $	��Top=�6T   $��GeoSlab703 Md BT)�6l   $��12(�6�   $��Normal&�6�   $��Normal$�6�   
�������6�   �� 5   
   -   5        $ txtDescricao��5      $
��Left=�6(   $��113,146,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��155��6�   $��1��6�   $��22��6�   $��Segoe UI Semilight)�6�   $��12(�6�   �� 5   
   $��Valor:��6   $
��Left=�6!   $��
22,174,0,0q�6<   $	��Top=�6P   $��GeoSlab703 Md BT)�6h   $��12(�6�   $��Normal&�6�   $��Normal$�6�   
�������6�   �� 5   
   -   5        $ txtValor��5      $
��Left=�6$   $��113,175,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $	��155��6�   $��2��6�   $��22��6�   $��Segoe UI Semilight)�6�   $��12(�6�   �� 5   
   $��	Criado Em��6   $
��Left=�6$   $��
22,203,0,0q�6?   $	��Top=�6S   
�������$��GeoSlab703 Md BT)�6~   $��12(�6�   �� 5   
   -   5        $ txtDate��5      $
��Left=�6#   $��113,204,0,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $	��156��6   $��4��6�   ${�False��6�   $��Segoe UI Semilight)�6�   $��23��6�   $��12(�6�   �� 5   
   -   5         ��Name$ btnCadastrarServico��5      $��0,0,0,0q�6.   $��	Cadastrar��6@   $
��Left=�6T   $��Georgia)�6p   $��13(�6�   $��17��6�   $	��Top=�6�   $��225,257,0,0q�6�   6�   �� 5   
   -   5        $ btnBuscarServico��5      $��0,0,0,0q�6+   $��Buscar��6=   $
��Left=�6N   $��Georgia)�6i   $��13(�6~   $	��Top=�6�   $��178,257,0,0q�6�   6�   �� 5   
   -   5        $ btnLimparServico��5      $��0,0,0,0q�6+   $��Limpar��6=   $��Georgia)�6N   $��13(�6c   $
��Left=�6q   $	��Top=�6�   $��128,257,0,0q�6�   6�   �� 5   
   -	   5        $ btnAlterarServico��5      $��0,0,0,0q�6,   $��Alterar��6>   $
��Left=�6P   $	��Top=�6k   ${�False��6�   $��Georgia)�6�   $��13(�6�   $��
78,257,0,0q�6�   6�   �� 5   
   -
   5        $ btnRemoverServico��5      $��0,0,0,0q�6,   $��Remover��6>   $
��Left=�6P   $	��Top=�6l   ${�False��6�   $��Georgia)�6�   $��13(�6�   $��
16,257,0,0q�6�   6�   5      5      