�������� ������ ������ �� ���������� Java, ������� ���� ������������� �������������� ������ �������� 
����� ���� ����� �� �������� �� C#  
����� Parse
1. �������������� ������ � ����:
- Parse(object o) - ����������� ������� ��� ���������, ��������� ����� Parse(Object o)
- int.Parse(o.ToString()) - ������������ ��������� ������ ��������������. 
2. ����������
- ���� �������� ������ ��� ��������������, ����� Parse ������ ������� 0. � ������ ���� �������� �� ��������������

����� Concat
1. �������������� ������ � ����:
- public string Concat(string[] lines) - ����������� �������� ��� ������������� �������� ������ � ��� ��������� 
- string result - ����������� ������� ��� result
- lines.Length - ������������ ����� ������ length
- string result - ���������� �� ����������������


 public int Parse(Object o) {
        int integer = 0;
        try{
            integer = Integer.parseInt(o.toString());
        }
        catch (Exception e){
        }
        return integer;
    }

    public String Concat(String[] lines) {
        String result = "";
        for(int i = 0; i < lines.length; i++) {
            result += lines[i];
        }
        return result;
    }