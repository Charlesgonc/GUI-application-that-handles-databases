   M S B A M L   `   `   `  ����B  >NBA.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:NBA.WPF.DataNBA.WPF.Data  5   	   'clr-namespace:NBA.WPF.VM
NBA.WPF.VM  5   	   'clr-namespace:NBA.WPF.UI
NBA.WPF.UI  5   	       NBA.WPF.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +dataclr-namespace:NBA.WPF.Data     5   	   'vmclr-namespace:NBA.WPF.VM     5   	   'uiclr-namespace:NBA.WPF.UI     5   	   -   5          � Title$  
MainWindow��5
   	   $	��372��6   $	��435��6)    � 	Resources 5      '   !NBA.WPF.UI.StatusToBrushConverter   StatusToBrushConverter(   "NBA.WPF.UI.HeightToStringConverter  HeightToStringConverter&    NBA.WPF.UI.DateToStringConverter  DateToStringConverter   NBA.WPF.VM.MainViewModel  VM  listTemplate �� DataType   NBA.WPF.Data.PlayerNBA �� Path �� 	Converter �� ContentStringFormat��%<  &	        &	      &	 &     &	 9     &	 L     7   7  7    5   
   6$     5   
   6%     5   
   6#     5   
   6   �� 5   
   "  6,   .R�5      ]� ��6   �� $ PlayerStatus�8   .+�5      �� $ Status: {0}��6>   $	��Top=�6`   ��6   �� $ PlayerStatus�6`   �� 5      $ 	Name: {0}��6<   $	��Top=�6\   ��6   �� $ 
PlayerName�6\   �� 5      $ Age: {0}��6;   $	��Top=�6Z   ��6   �� $ 	PlayerAge�6Z   �� 5      $ Position: {0}��6@   $	��Top=�6d   ��6   �� $ PlayerPosition�6d   �� 5      $ Field goal: {0}%��6A   $	��Top=�6h   ��6   �� $ PlayerFieldGoal�6h   �� 5      $ Height: {0}��6r   $	��Top=�6�   ��6   �� $ PlayerHeight�8  6�   �� 5      $ Weight: {0}kg��6>   $	��Top=�6b   ��6   �� $ PlayerWeight�6b   �� 5      $ Salary: ${0}��6>   $	��Top=�6a   ��6   �� $ PlayerSalary�6a   �� 5      $ Draft Date: {0}��6s   $	��Top=�6�   ��6   �� $ PlayerDraftDate�8  6�   �� 5      5      5      5       .��5!      �  � DataContext# [ 6   .+�5"   
   �� #��[ 6   $
��Left=�6�   $	��336��6�   $��10,0,0,0q�6�   $��Center=�6�   $	��258��6�   $��Stretch=�6�   ��6?   �� $ 
AllPLayers� �� SelectedItem 6g   �� $ SelectedPlayer�6�   �� 5$   
   $	��ADD��67   $
��Left=�6E   $��
284,15,0,0q�6`   $	��Top=�6t   $��61��6�   $��97��6�   ��6   �� $ AddPlayerCMD�6�   �� 5%   
   $
��EDIT��68   $
��Left=�6G   $��
284,93,0,0q�6b   $	��Top=�6v   $��62��6�   $��97��6�   ��6   �� $ EditPlayerCMD�6�   �� 5&   
   $��DELETE��6:   $
��Left=�6K   $��284,178,0,0q�6f   $	��Top=�6{   $��62��6�   $��97��6�   ��6   �� $ DeletePlayerCMD�6�   5'      5(      