using HRIS.Teaching;
using HRIS.Controller;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Controller
{
    public class UnitController
    {
        public ObservableCollection<UnitClass> viewableClass;
        private ObservableCollection<Unit> viewableUnit { get; set; }
        public ObservableCollection<Unit> VisibleUnits { get { return viewableUnit; } set { } }
        public ObservableCollection<UnitClass> VisibleClass { get { return viewableClass; }set { } }
        private List<Unit> units;
        private List<UnitClass> classes;


        public UnitController()
        {
            units = UnitAdapter.LoadAll();
            units = units.OrderBy(Unit => Unit.Title).ToList();
            classes = ClassAdapter.LoadAllClass();
            //foreach (var e in units)
            //{
            //    //List<UnitClass> classes = new List<UnitClass>();
                
            //    foreach (UnitClass f in classes)
            //    {
            //        if (f.Code==e.Code)
            //        {
            //            if(e.UnitClass == null)
            //            {
            //                e.UnitClass = new List<UnitClass>();
            //            }
            //            e.UnitClass.Add(f);
            //        }
            //    }
            //}
            viewableUnit = new ObservableCollection<Unit>(units);
            viewableClass = new ObservableCollection<UnitClass>(classes);

        }

        public ObservableCollection<Unit> GetViewableUnitList()
        {
            return VisibleUnits;
        }

        public ObservableCollection<UnitClass> GetViewableClassList()
        {
            return VisibleClass;
        }

        public ObservableCollection<UnitClass> FilterByCampus(Campus campus)
        {
            ObservableCollection<UnitClass> viewableClass = new ObservableCollection<UnitClass>();
            List<UnitClass> unitclass = new List<UnitClass>();
            unitclass = ClassAdapter.LoadAllClass();
            if (campus != Campus.All)
            {


                var filtered = from UnitClass e in unitclass where e.Campus == campus select e;
                viewableClass.Clear();
                //Converts the result of the LINQ expression to a List and then calls viewableStaff.Add with each element of that list in turn
                filtered.ToList().ForEach(viewableClass.Add);
            }
            else
            {
                var filtered = from UnitClass e in unitclass select e;
                viewableClass.Clear();
                filtered.ToList().ForEach(viewableClass.Add);
            }
            return viewableClass;

        }

        public void FilterByInput(String str)
        {
            var filtered = from Unit e in units where (e.Code+e.Title).ToLower().Contains(str.ToLower()) select e;
            viewableUnit.Clear();
            //Converts the result of the LINQ expression to a List and then calls viewableStaff.Add with each element of that list in turn
            filtered.ToList().ForEach(viewableUnit.Add);


        }


    }
}
