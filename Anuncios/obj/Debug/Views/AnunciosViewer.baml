   M S B A M L   `   `   `  ����C  ?Anuncios, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Anuncios.ViewModelsAnuncios.ViewModels  5      -clr-namespace:Anuncios.CoreAnuncios.Core  5	      #    Anuncios.Views.AnunciosViewer   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0vm!clr-namespace:Anuncios.ViewModels     5      -colorclr-namespace:Anuncios.Core     5	      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5
        � Title$  AnunciosViewer��5       � WindowStartupLocation$ CenterScreen=�6    � 	Resources 5      +   %Anuncios.ViewModels.AnunciosViewModel   
AnunciosVM"   Anuncios.Core.BrushConverter  BrushConverter��%:   &	        &	        5   
   6     5   
   6   5      .��5      �  � DataContext# [  6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� ��6   �� *ListaAnuncios+ �� SelectedItem 69   �� *CurrentAnuncio+��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      �� 5       �� Binding 6&   �� *Cuerpo+	 �� Value	 Rojo6A   .a�5      �� 
 �� Property
 � �� �� Value
 �  ��6I   5      �� 5       6&   �� *Cuerpo+	 Azul6A   .a�5       �� 
 � ��
 ��  �6J   5!      �� 5"       6&   �� *Cuerpo+	 Amarillo6A   .a�5#      �� 
 � ��
 � ���6L   5$      5*      .  (System.Windows.Interactivity.Interaction   Triggers 51      /  )System.Windows.Interactivity.EventTrigger  52         	EventName$ Loaded��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 53      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *ListarAnunciosCommand+54      ��56      �� 57      .R�58      �  � ColumnDefinitions 59      �� 5:      $��50 �6/   �� 5;      $��50 �6/   �� 5<      $	��500 �6/   �� 5=      $
��Auto �6/   .+�5?      �� $��1��6$   ��64   �� *Id+�� 5@      $��2��6$   ��64   �� *Nombre+�� 5A      $��3��6$   ��64   �� *Cuerpo+5B      5C      5E      �� 5F   
   $��1��6   ��6   �� *ListaAnuncios.Count+�� 5G   
   $��1��6;   $��Listar��6H   $��Right=�6Y   ��6   �� *ListarAnunciosCommand+6Y   �� 5H   
   $��1��64   $��Ver Info��6A   $��Right=�6T   $��26��6p   $	��Top=�6|   $��0,0,57,0q�6�   ��6   �� *verInfoCommand+6�   5I      5L      