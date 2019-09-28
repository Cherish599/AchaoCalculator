using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataBase;
using Entity;

namespace DaoLayer
{
    public class StudentDAO
    {
        public int getStudentRecordsNums()
        {
             List<Student> studengList=StudentDataset.getAll();
             return studengList.Count;
        }

        public List<Student> getAllStudents()
        {
            List<Student> studengList = StudentDataset.getAll();
            return studengList;
        }

    }
}
