   M S B A M L   `   `   `  ����  WhereTheMole#    WhereTheMole.Views.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      T PCatel.Extensions.Controls, Version=4.5.4.0, Culture=neutral, PublicKeyToken=nullE ACatel.MVVM, Version=4.5.4.0, Culture=neutral, PublicKeyToken=null'catelhttp://catel.codeplex.com   5        � WindowStartupLocation$  CenterScreen=�5       � Icon$ /Images/mole.png��5      $	��780��5      $	��790��5       � 
ResizeMode$ NoResize=�5	      .��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      �� 5      $��40 �6   .+�5   
   �� $��Center=�6    �� Orientation$ 
Horizontal=�62   .+�5      �� $��0, 10q�6   $��18(�6'   
����  �$��	Счет:��6G   �� 5      $��5, 10q�6   $��18(�6'   
���  ����6F   �� *Count+5      �� 5   
   $��1��6   .+�5      �� $��/Images/burrow.png��6   �� 5      $	��-10q�6   $��/Images/sun.png��6!    J� RenderTransformOrigin$ 0.5, 0.5&�6:   $��4��6[   z�5      �� 5       � Triggers 5      :� 5       :� RoutedEvent$ Loaded��6#   .[�5      �� .��5      �� .��5    "   W�  �� TargetProperty$5 /(Image.RenderTransform).(RotateTransform.Angle)�62   		 W� To$		 360X�5!   .   
 g� Duration$
 0:0:10D�67    g� RepeatBehavior$ Forever��6I   5"      5#      5$      5&      �� 5'      $��40, -10q�6   $��/Images/Cloud.png��6&   �� 5(      $��200, -10q�6   $��/Images/Cloud.png��6&   �� 5)      $��500, -10q�6   $��/Images/Cloud.png��6&   �� 5*      $��650, -10q�6   $��/Images/Cloud.png��6&   �� 5+       � Cursor$ Cross��6   ��6#   �� *
MarginMole+��6B   �� *Mole+ J� InputBindings 5,      d� 5-       d� Gesture$ 	LeftClicka�6#    �� Command 67   �� *ClickMoleCommand+5/      �� 50      $ Cross��6   ��6#   �� *MarginMouse+��6C   �� *Mouse+�� 51      $ Cross��6   ��6#   �� *
MarginMole+��6B   �� *Carrot+52      �� 53   
   $��Center=�6   ���#ffffe0$��2��6G   $ 
Horizontal=�6T   .+�54      �� $��10q�6   �� 55       �� TextDecorations$
 None{�56      $
��Bold"�57      $��18(�58      ���#7e462b �� Command 55      �� *ClickLinkCommand+.�59   1   97Скачать игру "Kто под шляпой?" >>5;      5<      5=      5?      5A      