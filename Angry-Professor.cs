    public static string angryProfessor(int k, List<int> a)
    {
        int EarlyStudents = 0;
        int LateStudents = 0;
        int ProfRequirement = k;
        
        foreach(int attendee in a)
        {
            if (attendee <= 0)
            {
                EarlyStudents+=1;
            }
            else
            {
                LateStudents += 1;
            }
        }
        
        if(EarlyStudents >= ProfRequirement)
        {
            return "NO";
        }
        else
        {
            return "YES";
        }
    }
