   M S B A M L   `   `   `  ����B  >WPF_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPF_AppWPF_App  5   	   7 clr-namespace:WPF_App.PropertiesWPF_App.Properties  5   	       WPF_App.playerStats   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPF_App     5   	   .p clr-namespace:WPF_App.Properties     5   	   -   5          � 
ResizeMode$  NoResize=�5   	   
 � Tag$ playerStats��5	       � Title$ playerStats��5
   	   $	��194��6   $	��500��6*    � WindowStyle$
 None=�5   
   $��5q�5   	   
����ح�
������ $��Kristen ITC)�5   	    � WindowStartupLocation$ Manual=�5   	    � 	Resources 5         
background 
� GradientOrigin � Offset � Color  BackgroundAnimation	 :� RoutedEvent	
 W� To �� TargetProperty g� Duration g� AutoReverse g� RepeatBehavior��%�  &	        &	 �     
� 5   
   $ 0.5,0.5&�61   ��5      � $ 0Q�6   $ 	LightBlue��6*   � 5      $	 1.6Q�6   $ ForestGreen��6,   5      :� 5   
   $	 StackPanel.Loaded��63   [�5      �� 5      .��5      �� .��5       W� $
 1X�6*   $( "Background.GradientStops[1].Offset�61   $ 0:0:2D�6p    . $ Forever��6�   5!      5"      5$      5%       � Triggers 5(      :� 5)   
   $	 Loaded��6   .[�5*      �� .��5+      �� .��5,      W� $ Width�6&    W� From$ 0X�6H   $	
 500X�6Q   $ 	00:00:.30D�6Z   5.      5/      50      .��52      � #��[  6    54   
   �� 55       �� ResourceKey$ BackgroundAnimation��6&    � RowDefinitions 57   
   �� 58      $��1* �6    � ColumnDefinitions 5;   
   �� 5<      $��2* �6   �� 5=      $��3* �6   .+�5?   
   �� $��0��6   $��0��6"   .+�5@      �� -   5        $��imagePortrait��5@      $	��233��6)   $	��Top=�66   $P��JC:\Users\Phyrexian\source\repos\WorldCup_Projekt\WPF_App\PlayerNoImage.png��6O   5A      5B      �� 5C   
   $��0��6   $��1��6"   .+�5D      �� -   5        $��lblName��5D      $��lblName��6#   $
��Bold"�65   $��33��6G   $��18(�6S   6c   �� 5E      -   5        $��lblShirtNumber��5E      $��18(�6+   $
��Bold"�69   $��30��6L   $��lblShirtNumber��6X   6s   �� 5F      -   5        $��lblPosition��5F      $��18(�6(   $
��Bold"�66   $��30��6I   $��lblPosition��6U   6m   �� 5G      -   5        $��
lblcaptain��5G      $��18(�6'   $
��Bold"�65   $��33��6H   "   WPF_App.Properties.Resources   Captain#��Z 6T   6   �� 5H      -   5        $��lblGoalsScored��5H      $��18(�6+   $
��Bold"�69   $��30��6L   $��lblGoalsScored��6X   6s   �� 5I      -   5        $��lblYellowCards��5I      $��18(�6+   $
��Bold"�69   $��30��6L   $��lblYellowCards��6X   6s   5J      5K      5L      