   M S B A M L   `   `   `  ����F  BM120Projekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:M120ProjektM120Projekt  5          M120Projekt.Register   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:M120Projekt     5      .��5	      �� .+�5
   
   � $��	0 20 0 20q�6   .+�5      �� -   5          ��Name$  btnNew��5      $	��Neu��6%   $��0 0 4 0q�63   $��97��6D   6]   �� 5      -   5        $  btnSave��5      $��	Speichern��6&   $��0 0 4 0q�6:   $��97��6K   6e   �� 5      -   5        $  	btnCancel��5      $��	Abbrechen��6(   $��0 0 4 0q�6<   $��97��6M   6i   �� 5      -   5        $  	btnDelete��5      $��Löschen��6(   $��97��6:   6V   5      �� 5   
   -   5         ��Name$ lblOperatorName��5      $��Operatorname��6)   6B   �� 5   
   -   5         ��Name$ txtOperatorName��5      $��1��6+   6z   �� 5   
   -   5        $ lblRealName��5      $��Richtiger Name��6%   6@   �� 5   
   -   5        $ txtRealName��5      $��2��6'   6r   �� 5   
   -	   5        $ lblAge��5      $��Alter��6    62   �� 5   
   -
   5        $ txtAge��5      $��3��6"   6h   �� 5   
   -   5        $ lblReleaseDate��5      $��Erscheinungsdatum��6(   6F   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpReleaseDate��5      $��4��6,   6s   �� 5   
   $��Position��6   6%   �� 5   
   -   5         ��Name$ 
cbPosition��5      $��5��6'   .@�5      �� -   5        $��
cbiAngriff��5      $��Angriff��6-    �� 
IsSelected . 6S   �� 5      -   5        $��cbiVerteidigung��5      $��Verteidigung��62   6K   5      �� 5   
   $��Rüstungspunkte��6   6+   � 5   
   .+�5       	� -   5         	�Name$ rbtnArmorPoints1��5       $��1��64   $��0 0 20 0q�6@   $��6��6R    d� 	IsChecked$
 TrueY�6_   6p   	� 5!      -   5        $ rbtnArmorPoints2��5!      $��2��64   $��0 0 20 0q�6@   $��7��6R   $ FalseY�6_   6�   	� 5"      -   5        $ rbtnArmorPoints3��5"      $��3��64   $��0 0 20 0q�6@   $��8��6R   $ FalseY�6_   6�   5#      �� 5$   
   $��Geschwindigkeitspunkte��6   63   � 5%   
   .+�5&      	� -   5        $ rbtnSpeedPoints1��5&      $��1��64   $��0 0 20 0q�6@   $��9��6R   $ FalseY�6_   6�   	� 5'      -   5        $ rbtnSpeedPoints2��5'      $��2��64   $��0 0 20 0q�6@   $��10��6R   $ FalseY�6`   6�   	� 5(      -   5        $ rbtnSpeedPoints3��5(      $��3��64   $��0 0 20 0q�6@   $��11��6R   $
 TrueY�6`   6�   5)      �� 5*   
   $0��*Handelt es sich um einen Standardoperator?��6   6G   � 5+   
   .+�5,      	� -   5        $ rbtnIsDefaultOperator��5,      $��Ja��69   $��0 0 20 0q�6F   $��12��6X   $ FalseY�6f   6�   	� 5-      -   5        $ rbtnIsNotDefaultOperator��5-      $
��Nein��6<   $��0 0 20 0q�6K   $��13��6]   $
 TrueY�6k   6�   5.      5/      50      