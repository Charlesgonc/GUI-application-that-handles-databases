   M S B A M L   `   `   `  ����B  >NBA.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:NBA.WPF.UI
NBA.WPF.UI  5   	   'clr-namespace:NBA.WPF.VM
NBA.WPF.VM  5   	       NBA.WPF.UI.EditorWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'uiclr-namespace:NBA.WPF.UI     5   	   'vmclr-namespace:NBA.WPF.VM     5   	     � Title$  EditorWindow��5	   	   $	��450��6   $	��800��6+    � 	Resources 5
      (   "NBA.WPF.UI.HeightToStringConverter   HeightToStringConverter&    NBA.WPF.UI.DateToStringConverter  DateToConverter    NBA.WPF.VM.EditorViewModel  VM��%W   &	        &	      &	 &       5   
   6%     5   
   6#     5   
   6   5      .��5      �  � DataContext# [ 6   .+�5   
   �� $��Name :��6   $
��Left=�6!   $��	54,47,0,0q�6<   $	��Top=�6O   $��28��6g   $��65��6s   $
��Left=�6~   $��Center=�6�   $��15(�6�   �� 5   
   $��Age :��6   $
��Left=�6    $��	54,90,0,0q�6;   $	��Top=�6N   $��31��6f   $��65��6r   $
��Left=�6}   $��Center=�6�   $��15(�6�   �� 5   
   $��Height :��6   $
��Left=�6#   $��
54,133,0,0q�6>   $	��Top=�6R   $��32��6j   $��65��6v   $
��Left=�6�   $��Center=�6�   $��15(�6�   �� 5   
   $��Weight :��6   $
��Left=�6#   $��
54,176,0,0q�6>   $	��Top=�6R   $��30��6j   $��65��6v   $
��Left=�6�   $��Center=�6�   $��15(�6�   �� 5   
   $��
Position :��6   $
��Left=�6%   $��
54,219,0,0q�6@   $	��Top=�6T   $��29��6l   $��65��6x   $
��Left=�6�   $��Center=�6�   $��15(�6�   �� 5   
   $��Status :��6   $
��Left=�6#   $��
54,262,0,0q�6>   $	��Top=�6R   $��30��6j   $��82��6v   $
��Left=�6�   $��Center=�6�   $��15(�6�   �� 5   
   $��Salary :��6   $��Center=�6#   $��0,51,0,0q�6@   $	��Top=�6R   $��29��6j   $��65��6v   $
��Left=�6�   $��Center=�6�   $��15(�6�   �� 5   
   $��Field Goal :��6   $
��Left=�6'   $��368,100,0,0q�6B   $	��Top=�6W   $��29��6o   $��98��6{   $
��Left=�6�   $��Center=�6�   $��15(�6�   �� 5   
   $
��Left=�6n   $��155,224,0,0q�6�   $	��Top=�6�   $	��120��6�   ��6   ��  �� Path$ 	Positions� �� SelectedItem 6:   �� $ Player.PlayerPosition�6�   �� 5   
   $
��Left=�6k   $��155,270,0,0q�6�   $	��Top=�6�   $	��120��6�   ��6   �� $ Statuses� 69   �� $ Player.PlayerStatus�6�   �� 5   
   $
��Left=�6<   $��
493,60,0,0q�6W    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��120��6�   ��6   �� $ Player.PlayerSalary�6�   �� 5   
   $
��Left=�6p   $��155,140,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6   �� $ Player.PlayerHeight� �� 	Converter# [  6�   �� 5   
   $
��Left=�6<   $��155,182,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��120��6�   ��6   �� $ Player.PlayerWeight�6�   �� 5   
   $
��Left=�6?   $��493,106,0,0q�6Z   $
 Wrap=�6o   $	��Top=�6�   $	��120��6�   ��6   �� $ Player.PlayerFieldGoal�6�   �� 5    
   $
��Left=�6:   $��
155,57,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��120��6�   ��6   �� $ Player.PlayerName�6�   �� 5!   
   $
��Left=�69   $��155,103,0,0q�6T   $
 Wrap=�6j   $	��Top=�6~   $	��120��6�   ��6   �� $ Player.PlayerAge�6�   �� 5"   
   $
��Left=�6   $��493,155,0,0q�6-   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6B   �� $ Player.PlayerDraftDate�# [ 6�   �� 5$   
   -   5        $��OK��5$      $
��Left=�6   $��368,223,0,0q�69   $	��Top=�6N   $��69��6f   $��88��6r   6}   �� 5%   
   -   5        $��Cancel��5%      $
��Left=�6"   $��525,224,0,0q�6=   $	��Top=�6R   $��69��6j   $��88��6v   6�   �� 5&   
   $��Draft Date :��6   $
��Left=�6'   $��368,149,0,0q�6B   $	��Top=�6W   $��29��6o   $��98��6{   $
��Left=�6�   $��Center=�6�   $��15(�6�   5'      5(      