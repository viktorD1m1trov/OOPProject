   M S B A M L   `   `   `  ����  WpfApplication1    WpfApplication1.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          �Name$  MyLoginWindow��5   	    � Title$ Login��5   	   $��108.661��6   $��298.818��6(    � WindowStyle$ 
ToolWindow=�5   	   
���� � � 
ResizeMode$ NoResize=�5   	    � 	Resources 5       	  MyImg��%5   &	        �� 5	   
   $��Resourses\img.jpg��6   5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��58* �6   �� 5      $	��72* �6   �� 5      $
��163* �6   .+�5   
   �� $��	Password:��6   $
��Left=�6$   $��27,9,0,0q�6?   $	��Top=�6Q   $��2��6i   $��Consolas)�6}   $��15(�6�   �� 5   
   -   5        ��. $��2��5   #   $��Login��60   $��1��6@   $
��Left=�6P   $��	26,42,0,0q�6k   $	��Top=�6~   $	��128��6�    J� RenderTransformOrigin$ 0.201,0.143&�6�   $��27��6�   $��Consolas)�6�   $��16(�6�   $��2��6  G� 5   
   -   5         G�Name$ PassBox��5   %    G� 	MaxLength$ 12��6   $��1��66   $��1��6C   $
��Left=�6S   $��	58,11,0,0q�6n   $	��Top=�6�   $	��151��6�   $��26��6�   $��2��6�   �� 5   
   -   5        	 ��Name$	 ShowPass��5      #��[  6#   $��2��6D   $
��Left=�6T   $��
107,11,0,0q�6o   $	��Top=�6�   $��31��6�   $��26��6�   ��.  
���   ���6�   Z� 6  �� 5   
   -   5        
 ��Name$
 txtBoxForPassWord��5      $��2��6-   $
��Left=�6A   $��	58,11,0,0q�6]    �� TextWrapping$
 Wrap=�6p   $	��Top=�6�   $	��120��6�   $��26��6�   $��1��6�   $��Consolas)�6�   $��14(�6�   5      5      