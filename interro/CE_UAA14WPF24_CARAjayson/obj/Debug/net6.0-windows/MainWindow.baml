   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $
��1000��6   $
��1200��6*   .��5	      � -   5         �Name$ mainGrid��5	      ���#EBD9B4 � ColumnDefinitions 5
   
   �� 5      $��2* �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      $��8* �6   �� 5      .+�5   
   �� $*��$VERIFIONS VOS CONNAISSANCES en WPF !��6   $��34(�6@   ���#9DBC98$��Center=�6c   $��Center=�6�   $��2��6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ TxtBMessage��5      $��Test WPF 6T 2024��6)   $��30(�6A   
��� E��$��Center=�6f   $��Center=�6�   $��2��6�   $
��Bold"�6�   $��2��6�   �� 5   
   $��1��6   $��1��6"   ���#9DBC98.+�5      �� $��Paramétrage��6   $��22(�6,   $
��Bold"�6:   $��
10,10,10,0q�6L   .��5      � .+�5      �� $��Choix de la disposition��6   $	��348��6@   $��10,30,10,15q�6L   .��5      �� .+�5      	� -   5         	�Name$ RbSolitaire��5   *   $��	Solitaire��6?   $��0,10,0,5q�6S   	� 5      -   5        $ 	RbMarelle��5   *   $��Marelle��6=   $��0,5,0,5q�6O   	� 5      -   5        $ RbBandeL��5   *   $��Une Bande Latérale��6<   $��0,5,0,0q�6Y   5      5      �� 5       -   5         ��Name$ Tp��5       $��Taille du plateau��6+   $	��348��6F   $��10,15,10,30q�6R   .��5!      �� .+�5"      � .+�5#   "   �� $��Nbre de Lignes��6,   �� 5$   "   -   5         ��Name$ TxtBxLignes��5$   *   $��30��6?   $��30��6J   $��50,0,0,0q�6V   5%      � 5&      .+�5'   "   �� $��Nbre de Colonnes��6,   �� 5(   "   -   5        $ TxtBxColonnes��5(   *   $��30��6A   $��30��6L   $��21,0,0,0q�6X   5)      5*      5+      5,      5-      �� 5.      -	   5         ��Name$ 
BtnValider��5.      $��VALIDER��6)   $��Center=�6;   $��Center=�6_   $��22(�6�   $
��Bold"�6�   $��50��6�   $��0,10,0,0q�6�   5/      � 51   
   -
   5        $ 
secondGrid��51      $��1��6#   53      55      56      