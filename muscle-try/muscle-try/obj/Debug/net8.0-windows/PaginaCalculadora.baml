   M S B A M L   `   `   `  ����  
muscle-try"    muscle_try.PaginaCalculadora   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        N� Title$  PaginaCalculadora��5      .��5      � $��20q�6   
������� � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0,0,0,20q�5      $��24(�5      $
��Bold"�5      $,��&Calculadora de IMC, Calorías y Macros��5      �� 5   
   $��1��5      $	��300��5      $��0,0,0,20q�5      $
��Left=�5       �� Orientation$ Vertical=�5      .+�5       �� $��
Peso (kg):��6   �� 5!      -   5         ��Name$ 	PesoInput��5!      $	��0,5q�6)   �� 5#      $��Altura (cm):��6   �� 5$      -   5        $ AlturaInput��5$      $	��0,5q�6+   �� 5&      $��Edad:��6   �� 5'      -   5        $ 	EdadInput��5'      $	��0,5q�6)   �� 5)      $��Sexo:��6   �� 5*      -   5         ��Name$ 	SexoCombo��5*      $	��0,5q�6*   .@�5+      �� $��Hombre��6   �� 5,      $��Mujer��6   5-      �� 5/      $��Nivel de actividad:��6   �� 50      -   5        $ ActividadCombo��50      $	��0,5q�6/   .@�51      �� $+��%Sedentario (poco o nada de ejercicio)��6   �� 52      $#��Ligero (1-3 días por semana)��6   �� 53      $%��Moderado (3-5 días por semana)��6   �� 54      $#��Activo (6-7 días por semana)��6   �� 55      $$��Muy activo (dos veces al día)��6   56      �� 59      -   5        $��0,15,0,0q�5:      $��Calcular��5<      5=      �� 5@   
   $��2��6   $��0,10,0,0q�6"   .+�5A      �� $
��0,10q�5B      $��16(�5C      $
��Bold"�5D      $��
Resultado:��5E      �� 5F      -   5         ��Name$ ResultadoIMC��5F      $	��0,5q�6.   �� 5G      -   5        $ ResultadoCalorias��5G      $	��0,5q�63   �� 5H      -	   5        $ ResultadoMacros��5H      $	��0,5q�61   5I      5J      5K      