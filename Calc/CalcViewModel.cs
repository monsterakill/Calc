using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Calc
{
    class CalcViewModel : INotifyPropertyChanged
    {
        //Prev Operation
        enum LastOperation
        { None, Add, Subtract, Multiply, Divide };

        CalcModel Model;
        Double tempNumber;
        LastOperation lastOperation;
        bool bNewEntry;
        public CalcViewModel()
        {
            Model = new CalcModel();
            tempNumber = 0;
            lastOperation = LastOperation.None;
            bNewEntry = false;
        }


        public double updateNumber
        {
            get {
                return Model.Number;
            }
            set
            {
                if (Model.Number == 0)
                    Model.Number = value;
                else if (bNewEntry)
                {
                    Model.Number = value;
                    bNewEntry = false;
                }
                else
                    Model.Number = double.Parse(Model.Number.ToString() + value.ToString());

                RaisePropertyChanged("updateNumber");
            }
        }

        public void add()
        {
            if (lastOperation == LastOperation.Add)
            {
                double sum = Model.add(updateNumber, tempNumber);
                clear();
                updateNumber = sum;
            }
            tempNumber = updateNumber;
            bNewEntry = true;

            lastOperation = LastOperation.Add;
        }
        public void subtract()
        {

            if (lastOperation == LastOperation.Subtract)
            {
                double sum = Model.subtract(tempNumber, updateNumber);
                clear();
                updateNumber = sum;
            }
            tempNumber = updateNumber;
            bNewEntry = true;
            lastOperation = LastOperation.Subtract;
        }

        public void Multiply()
        {
            if (lastOperation == LastOperation.Multiply)
            {
                double sum = Model.Multiply(tempNumber, updateNumber);
                clear();
                updateNumber = sum;
            }
            tempNumber = updateNumber;
            bNewEntry = true;
            lastOperation = LastOperation.Multiply;
        }

        public void Divide()
        {
            if (lastOperation == LastOperation.Divide)
            {
                double sum = Model.Divide(tempNumber, updateNumber);
                clear();
                updateNumber = sum;
            }
            tempNumber = updateNumber;
            bNewEntry = true;
            lastOperation = LastOperation.Divide;
        }

        public void clear()
        {
            Model.Number = 0;
            updateNumber = 0;
        }

        public void clearAll()
        {
            Model.Number = 0;
            updateNumber = 0;
            tempNumber = 0;
            bNewEntry = false;
            lastOperation = LastOperation.None;
        }

        public void equal()
        {
            if (lastOperation == LastOperation.Add)
                add();
            else if (lastOperation == LastOperation.Multiply)
                Multiply();
            else if (lastOperation == LastOperation.Divide)
                Divide();
            else if (lastOperation == LastOperation.Subtract)
                subtract();
            lastOperation = LastOperation.None;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}