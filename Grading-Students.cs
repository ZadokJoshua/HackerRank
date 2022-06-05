    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> newGrades = new List<int>();
        foreach(int num in grades)
        {
            int temp = num, diff = 0;
            
            if(num < 37)
            {
                newGrades.Add(num);
            }
            else
            {
                temp += (5 - (temp % 5));
                diff = temp - num;
                
                if(diff < 3)
                {
                    newGrades.Add(temp);
                }
                else
                {
                   newGrades.Add(num);
                }
            }
        }
        
        return newGrades;
    }
