using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIS.Controller;
using HRIS.Teaching;

namespace HRIS.View
{
    class ClassListView
    {
        public ObservableCollection<UnitClass> viewableClass;
        public ObservableCollection<UnitClass> VisibleClass { get { return viewableClass; } set { } }
        private List<UnitClass> classes;


        public ClassListView()
        {
            classes = ClassAdapter.LoadAllClass();
            viewableClass = new ObservableCollection<UnitClass>(classes);
        }


        public ObservableCollection<UnitClass> GetViewableClassList()
        {
            return VisibleClass;
        }

        public void FilterByCampus(Campus campus)
        {
            if (campus != Campus.All)
            {


                var filtered = from UnitClass e in classes where e.Campus == campus select e;
                viewableClass.Clear();
                //Converts the result of the LINQ expression to a List and then calls viewableStaff.Add with each element of that list in turn
                filtered.ToList().ForEach(viewableClass.Add);
            }
            else
            {
                var filtered = from UnitClass e in classes select e;
                viewableClass.Clear();
                filtered.ToList().ForEach(viewableClass.Add);
            }
        }

        public void FilterByCode(String code)
        {
            var filtered = from UnitClass e in classes where code.Contains(e.Code) select e;
            viewableClass.Clear();
                //Converts the result of the LINQ expression to a List and then calls viewableStaff.Add with each element of that list in turn
            filtered.ToList().ForEach(viewableClass.Add);

        }


    }
}

