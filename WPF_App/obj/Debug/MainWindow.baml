   M S B A M L   `   `   `  ����B  >WPF_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPF_AppWPF_App  5   	   7 clr-namespace:WPF_App.PropertiesWPF_App.Properties  5   	       WPF_App.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPF_App     5   	   .p clr-namespace:WPF_App.Properties     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	   $��Kristen ITC)�5
   	   
 � Tag$ 
MainWindow��5       � Title$ Field Preview��5      $	��815��6M   $
��1300��6Z    � 	Resources 5         
background �� 
StartPoint �� EndPoint � Offset � Color  BackgroundAnimation :� RoutedEvent		 W� To
 �� TargetProperty g� Duration g� AutoReverse g� RepeatBehavior��%�  &	        &	 �     �� 5   
   $ 0,0.5&�61   $ 1,0.5&�6D   ��5      � $ 0Q�6   $ ForestGreen��6*   � 5      $ 0Q�6   $ 	LightBlue��6*   � 5      $ 1Q�6   $ ForestGreen��6*   5      :� 5   
   $ StackPanel.Loaded��63   [�5      �� 5      .��5      �� .��5      W� $	 1X�6*   $(
 "Background.GradientStops[1].Offset�61   $ 0:0:5D�6p    . $ Forever��6�   5      5      5       5!       � Triggers 5#      :� 5$   
   $ Loaded��6   .[�5%      �� .��5&      �� .��5'      W� $
 Opacity�6&    W� From$ 0X�6J   $	 1X�6S   $ 00:00:03D�6Z   5(      5)      5*      .��5-      � -   5        $��allcomponents��5-       � ColumnDefinitions 5/   
   �� 50      $��2* �6    � RowDefinitions 52   
   �� 53      $
��0.4* �6   �� 54      $
��1.2* �6   �� 55      $��13.5* �6   .+�57   
   ]� $��0��6   $��0��6!   
�������.+�58      o� -   5        $
��menu��58   ,   $��Kristen ITC)�6   $	��Top=�68   
�������.@�59      m� -   5        $��Options��59      "   WPF_App.Properties.Resources   Options#��Z 6*   
�������.@�5:      m� -   5        $��newTeam��5:         ChooseAnewTeam#��Z 6.   6]   m� 5;      -   5        $��changeLanguage��5;         ChangeLanguage#��Z 65   .@�5<      m� -   5        $��CroatianMenuItem��5<   #    m� IsCheckable .    Croatian#��Z 6N   6w   m� 5=      -   5        $��EnglishMenuItem��5=   #    .    English#��Z 6M   6u   5>      m� 5?      -	   5        $��changeWindowSize��5?         
WindowSize#��Z 67   .@�5@      m� -
   5        $��WindowedMenuItem��5@   #    .    Windowed#��Z 6N   6w   m� 5A      -   5        $��FullscreenMenuItem��5A   #    .    	Maximized#��Z 6P   6z   5B      5C      5D      5F      � 5G   
   -   5        $��	gridStats��5G      $��1��6    $��0��6-   $��15(�6=   $��DemiBold"�6W   #��[  6y    5I      �� 5J       �� ResourceKey$ BackgroundAnimation��6*    5M      �� 5N      $��2* �6#   �� 5O      $��1* �6#   �� 5P      $��2* �6#    5S      �� 5T      $��1* �6    �� 5U      $��1* �6    .+�5X      �� $��Center=�6   $��0��66   $��0��6F    �� Orientation$ 
Horizontal=�6S   .+�5Y      �� -   5        $��lblGamesPlayed_Home��5Y      61   �� 5Z      -   5        $��lblGamesWon_Home��5Z      63   �� 5[      -   5        $��lblGamesLost_Home��5[      65   �� 5\      -   5        $��lblGamesDrawn_Home��5\      65   5]      �� 5^      $��Center=�6   $��0��67   $��1��6G   $ 
Horizontal=�6T   .+�5_      �� -   5        $��lblGoalsScored_Home��5_      66   �� 5`      -   5        $��lblGoalsReceived_Home��5`      68   �� 5a      -   5        $��lblGoalsDifferential_Home��5a      6<   5b      �� 5d      $��Center=�6   $��2��66   $��0��6F   $ 
Horizontal=�6S   .+�5e      �� -   5        $��lblGamesPlayed_Away��5e      66   �� 5f      -   5        $��lblGamesWon_Away��5f      63   �� 5g      -   5        $��lblGamesLost_Away��5g      64   �� 5h      -   5        $��lblGamesDrawn_Away��5h      65   5i      �� 5j      $��Center=�6   $��2��67   $��1��6G   $ 
Horizontal=�6T   .+�5k      �� -   5        $��lblGoalsScored_Away��5k      65   �� 5l      -   5        $��lblGoalsReceived_Away��5l      68   �� 5m      -   5        $��lblGoalsDifferential_Away��5m      6;   5n      �� 5p      $��Center=�6   $��Center=�66   $ 
Horizontal=�6Q   $��1��6j   $��0��6z   $��2��6�   .+�5q      �� -   5        $��lblVS��5q   /   $��	ExtraBold"�6   6>   5r      5t      � 5u   
   -   5        $��	gridField��5u      $��2��6    $��0��6-   ��5v      �� 5w       �� ImageSource$ footballField.png��6    j� 
AlignmentY$	 Top=�6>    j� 
AlignmentX$ Center=�6O    5y   
   �� 5z      $��1* �6   �� 5{      $��1* �6   �� 5|      $��1* �6   �� 5}      $��1* �6   �� 5~      $��1* �6    5�   
   �� 5�      $��1* �6   �� 5�      $��1* �6   �� 5�      $��1* �6   �� 5�      $��1* �6   �� 5�      $��1* �6   �� 5�      $��1* �6   �� 5�      $��1* �6   �� 5�      $��1* �6   �� 5�      $��1* �6   5�      5�      5�      