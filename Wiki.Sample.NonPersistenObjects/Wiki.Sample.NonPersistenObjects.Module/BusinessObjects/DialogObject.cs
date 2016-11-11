namespace Wiki.Sample.NonPersistenObjects.Module.BusinessObjects
{
    using System;
    using System.ComponentModel;
    using System.Linq;
    using DevExpress.ExpressApp;
    using DevExpress.ExpressApp.DC;
    using DevExpress.Xpo;

    [DomainComponent]
    public class DialogObject : IXafEntityObject, IObjectSpaceLink, INotifyPropertyChanged
    {
        private IObjectSpace objectSpace;
        private void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public DialogObject()
        {
        }


        [Browsable(false), Key]
        public int ID { get; set; }

        string inputString;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string InputString
        {
            get
            {
                return inputString;
            }
            set
            {
                if (this.inputString != value)
                {
                    this.inputString = value;
                    this.OnPropertyChanged("InputString");
                }
            }
        }

        int inputNumber;
        public int InputNumber
        {
            get
            {
                return inputNumber;
            }
            set
            {
                if (this.inputNumber != value)
                {
                    this.inputNumber = value;
                    this.OnPropertyChanged("InputNumber");
                }
            }
        }

        PersistentObject persistentObject;
        public PersistentObject PersistentObject
        {
            get
            {
                return persistentObject;
            }
            set
            {
                if (this.persistentObject != value)
                {
                    this.persistentObject = value;
                    this.OnPropertyChanged("PersistentObject");
                }
            }
        }
        #region IXafEntityObject members (see https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppIXafEntityObjecttopic.aspx)
        void IXafEntityObject.OnCreated()
        {
            // Place the entity initialization code here.
            // You can initialize reference properties using Object Space methods; e.g.:
            // this.Address = objectSpace.CreateObject<Address>();
        }
        void IXafEntityObject.OnLoaded()
        {
            // Place the code that is executed each time the entity is loaded here.
        }
        void IXafEntityObject.OnSaving()
        {
            // Place the code that is executed each time the entity is saved here.
        }
        #endregion

        #region IObjectSpaceLink members (see https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppIObjectSpaceLinktopic.aspx)
        // Use the Object Space to access other entities from IXafEntityObject methods (see https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113707.aspx).
        IObjectSpace IObjectSpaceLink.ObjectSpace
        {
            get { return objectSpace; }
            set { objectSpace = value; }
        }
        #endregion

        #region INotifyPropertyChanged members (see http://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged(v=vs.110).aspx)
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}