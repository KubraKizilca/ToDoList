   M S B A M L   `   `   `  ����C  ?ToDoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ToDoListToDoList  5   	       ToDoList.DoListItem   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   "localclr-namespace:ToDoList  5   	     � Title$  
DoListItem��5	   	   $	��700��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�66   .��5
      � $��10,10,-0.4,0q�6   $	��626��6!   $	��Top=�6.    � ColumnDefinitions 5   
   �� 5      $
��231* �6   �� 5      $
��163* �6   �� 5      $
��390* �6   .+�5   
   �� -   5        $��txt_name��5      $��20(�6"   $
��Left=�60   $��33��6K   $��109.4,10,-4,0q�6W    �� TextWrapping$
 Wrap=�6n   $	��Top=�6�   $	��285��6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	List name��6�   $��2��6�   �� 5   
   -   5        $��txt_description��5      $��20(�6)   $
��Left=�67   $��33��6R   $��109.4,43,-4,0q�6^   $
 Wrap=�6u   $	��Top=�6�   $	��285��6�   $ Description��6�   $��2��6�   �� 5   
   -   5        $��KAYDET��5      $
��Left=�61   $��125,594,0,0q�6L   $	��Top=�6a   $��95��6y    J� RenderTransformOrigin$ 0.601,8.465&�6�   $��2��6�   $��1��6�   �� 5   
   -   5        $	��lbx��5      $
��Left=�6K   $	��512��6f   $��	10,60,0,0q�6s   $	��Top=�6�   $	��302��6�   $��2��6�   �� 5   
   $
��Left=�6   $��
120,15,0,0q�60   $
��Wrap=�6D   $��Item Name :��6X   $	��Top=�6k   $ 0.435,0.888&�6�   $��29��6�   $	��112��6�   $��20(�6�   $��2��6�   $��1��6�   �� 5   
   $
��Left=�6   $��
120,49,0,0q�6/   $
��Wrap=�6C   $��Item Description:��6W   $	��Top=�6p   $��20(�6�   $��2��6�   $��1��6�   �� 5   
   $
��Left=�6   $��119.6,130,0,469q�6/   $
��Wrap=�6H   $��Item Deadline :��6\   $ 
0.29,1.515&�6s   $��20(�6�   $��2��6�   $��1��6�   �� 5   
   $
��Left=�6   $��
125,82,0,0q�6/   $
��Wrap=�6C   $��Status :��6W   $	��Top=�6g   $��20(�6   $��2��6�   $��1��6�   �� 5   
   $��Selected date:��6   $��22.4,507,178,91q�6)   $��2��6B   �� 5   
   -   5        $��txt_deadline��5      $��22.4,540,10,56q�6�   $��2��6�   ��6&   �� *SelectedDate+ �� ElementName$ 	cldSample�� �� StringFormat$ d�� �� UpdateSourceTrigger$ PropertyChanged=�6�   &   System.Windows.Controls.Calendar  5   
   -   5        	  Name$	 	cldSample��5      
   SelectionMode$
 MultipleRange=�6&      SelectedDate$ 
10.10.2013X�6D   $��109.4,130,10,149q�6^   $��2��6x   �� 5   
   -   5        $
��SİL��5      $
��Left=�6+   $��75.4,594,0,0q�6F   $	��Top=�6\   $��95��6t   $ 0.601,8.465&�6   $��2��6�   �� 5   
   -   5        $��	GÜNCELLE��5      $
��Left=�65   $��191.4,594,0,0q�6P   $	��Top=�6g   $	��110��6   $ 0.601,8.465&�6�   $��2��6�   �� 5   
   -	   5         ��Name$ complete��5      $��Complete��6%   $
��Left=�68   $��109.4,81,0,0q�6S   $	��Top=�6i   $	��124��6�   $��36��6�   $��2��6�   �� 5   
   $
��Left=�6   $��
10,0,0,587q�6/   $
��Wrap=�6C   $��Order By��6W   $��Bottom=�6g   $��19��6�   �� 5    
   -
   5        $
 name��5       $
��Name��6$   $
��Left=�63   $��	71,21,0,0q�6N   $	��Top=�6a   6y   �� 5!   
   -   5        $ status��5!      $��Status��6#   $
��Left=�64   $��
145,20,0,0q�6O   $	��Top=�6c   6{   5$      5%      