�������� � ������������ ������ �� Java(Math.round, random.nextDouble �.�.)
��� ������ (GetRandomNumber1() � GetRandomNumber2()) ����� ����������. � ����� ������������ �������� double. ������ 
�������� �������� ��������� ������ ��� ���������� �������� ������:
- � ������ GetRandomNumber1(): Round((random.NextDouble() - 0.5) * 2);
- � ������ GetRandomNumber1(): Round((random.NextDouble() - 0.5) * 2.99);
������� ������� ��� ��������� �� 2 � ������ ������ � ��������� �� 2.99 �� ������ ������

������:
���� ������ ������ random.NextDouble() �������� 0.7, ��:

- ����� GetRandomNumber1(): 
(0.7 - 0.5) * 2) = 0.4

- ����� GetRandomNumber2(): 
(0.7 - 0.5) * 2.99) = 0.598

��� �������� ����� Random ��������� �������� �� ���������� ������, ������:
- ����� GetRandomNumber1() ��������� ��������: 0.0
- ����� GetRandomNumber1() ��������� ��������: 1.0

 