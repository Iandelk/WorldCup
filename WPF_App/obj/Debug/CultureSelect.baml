   M S B A M L   `   `   `  ����B  >WPF_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPF_AppWPF_App  5   	       WPF_App.CultureSelect   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPF_App     5   	     � WindowStartupLocation$  CenterScreen=�5   	   $��Kristen ITC)�5	   	   
 � Tag$ CultureSelect��5
   
    � Title$ Select Culture��5   	   $	��400��6    $	��400��6-    � 	Resources 5         
background �� 
StartPoint �� EndPoint � Offset � Color  BackgroundAnimation :� RoutedEvent		 W� To
 �� TargetProperty g� Duration g� AutoReverse g� RepeatBehavior��%�  &	        &	 �     �� 5   
   $	 0,0&�61   $	 1,1&�6B   ��5      � $ 0Q�6   $ ForestGreen��6*   � 5      $ 0Q�6   $ 	LightBlue��6*   � 5      $ 1Q�6   $ ForestGreen��6*   5      :� 5   
   $ StackPanel.Loaded��63   [�5      �� 5      .��5      �� .��5      W� $	 1X�6*   $(
 "Background.GradientStops[1].Offset�61   $ 0:0:3D�6p    . $ Forever��6�   5      5      5      5       .��5"      �� $��2q�6   #��[  6    � Triggers 5#   
   �� 5$       �� ResourceKey$ BackgroundAnimation��6&   .+�5&   
   �� $��Choose Language��6   $��16(�6*   $
��Bold"�68   $��0,30,0,0q�6K   $��Center=�6]   6|   �� 5'   
   -   5        $��cb_Language��5'   %   $
��Bold"�6   $	��200��68   $��0,20,0,0q�6D    �� 
IsEditable .  �� 
IsReadOnly . 5(      �� 5)   
   $��Choose Size��6   $��16(�6&   $
��Bold"�64   $��0,30,0,0q�6G   $��Center=�6Y   6x   �� 5*   
   -   5        $��cb_size��5*   %   $
��Bold"�6   $	��200��64   $��0,20,0,0q�6A    .  . 5+      �� 5,   
   -   5        $
��Bold"�5,      
�������$	��100��66   $��50��6B   $��Accept��6N   $��0,50,0,0q�6`   6�   5-      5.      