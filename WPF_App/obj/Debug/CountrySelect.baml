   M S B A M L   `   `   `  ����B  >WPF_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPF_AppWPF_App  5   	   7 clr-namespace:WPF_App.PropertiesWPF_App.Properties  5   	       WPF_App.CountrySelect   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPF_App     5   	   .p clr-namespace:WPF_App.Properties     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	   
 � Tag$ CultureSelect��5
   	   $��Kristen ITC)�5   	   "   WPF_App.Properties.Resources   SelectCountries � Title# Z 5   	   $	��400��68   $	��400��6E    � 	Resources 5         
background �� 
StartPoint �� EndPoint � Offset � Color  BackgroundAnimation	 :� RoutedEvent	
 W� To �� TargetProperty g� Duration g� AutoReverse g� RepeatBehavior��%�  &	        &	 �     �� 5   
   $	 0,0&�61   $	 1,1&�6B   ��5      � $ 0Q�6   $ ForestGreen��6*   � 5      $ 0Q�6   $ 	LightBlue��6*   � 5      $ 1Q�6   $ ForestGreen��6*   5      :� 5   
   $	 StackPanel.Loaded��63   [�5      �� 5      .��5      �� .��5      W� $
 1X�6*   $( "Background.GradientStops[1].Offset�61   $ 0:0:3D�6p    . $ Forever��6�   5      5      5       5!      .��5#      �� $��2q�6   #��[  6    � Triggers 5$   
   �� 5%       �� ResourceKey$ BackgroundAnimation��6&   .+�5'   
   ��    ChooseHomeCountry#��Z 6   $��16(�6C   $
��Bold"�6Q   $��0,30,0,0q�6c   $��Center=�6u   6�   �� 5(   
   -   5        $��cb_HomeCountry��5(   %   $
��Bold"�6   $	��200��6;   $��0,20,0,0q�6G    �� 
IsEditable .  �� 
IsReadOnly . 5)      �� 5*   
      ChooseAwayCountry#��Z 6   $��16(�6C   $
��Bold"�6Q   $��0,30,0,0q�6c   $��Center=�6u   6�   �� 5+   
   -   5        $��cb_AwayCountry��5+   %   $
��Bold"�6   $	��200��6;   $��0,20,0,0q�6H    .  . 5,      �� 5-   
   -   5        $
��Bold"�5-      
�������$	��100��66   $��50��6B      	btnAccept#��Z 6N   $��0,50,0,0q�6z   6�   5.      5/      