﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Linq;

namespace Tester.Data
{
    /// <summary>
    /// The class representing the dbo.Left table.
    /// </summary>
    [System.Data.Linq.Mapping.Table(Name="dbo.Left")]
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(Metadata))]
    [System.Data.Services.Common.DataServiceKey("Id")]
    [System.Diagnostics.DebuggerDisplay("Id: {Id}")]
    public partial class Left
        : LinqEntityBase, ICloneable
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="Left"/> class.
        /// </summary>
        static Left()
        {
            CodeSmith.Data.Rules.RuleManager.AddShared<Left>();
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Left"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        public Left()
        {
            OnCreated();
            Initialize();
        }

        private void Initialize()
        {
            _junctionList = new System.Data.Linq.EntitySet<Junction>(OnJunctionListAdd, OnJunctionListRemove);
        }
        #endregion

        #region Column Mapped Properties

        private int _id = default(int);

        /// <summary>
        /// Gets the Id column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Id", Storage = "_id", DbType = "int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 1)]
        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    OnIdChanging(value);
                    SendPropertyChanging("Id");
                    _id = value;
                    SendPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }

        private string _name;

        /// <summary>
        /// Gets or sets the Name column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Name", Storage = "_name", DbType = "nvarchar(50) NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        [System.Runtime.Serialization.DataMember(Order = 2)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    OnNameChanging(value);
                    SendPropertyChanging("Name");
                    _name = value;
                    SendPropertyChanged("Name");
                    OnNameChanged();
                }
            }
        }

        private System.DateTime _createdDate;

        /// <summary>
        /// Gets or sets the CreatedDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "CreatedDate", Storage = "_createdDate", DbType = "datetime NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 3)]
        public System.DateTime CreatedDate
        {
            get { return _createdDate; }
            set
            {
                if (_createdDate != value)
                {
                    OnCreatedDateChanging(value);
                    SendPropertyChanging("CreatedDate");
                    _createdDate = value;
                    SendPropertyChanged("CreatedDate");
                    OnCreatedDateChanged();
                }
            }
        }

        private System.DateTime _modifiedDate;

        /// <summary>
        /// Gets or sets the ModifiedDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "ModifiedDate", Storage = "_modifiedDate", DbType = "datetime NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 4)]
        public System.DateTime ModifiedDate
        {
            get { return _modifiedDate; }
            set
            {
                if (_modifiedDate != value)
                {
                    OnModifiedDateChanging(value);
                    SendPropertyChanging("ModifiedDate");
                    _modifiedDate = value;
                    SendPropertyChanged("ModifiedDate");
                    OnModifiedDateChanged();
                }
            }
        }

        private System.Data.Linq.Binary _rowVersion = default(System.Data.Linq.Binary);

        /// <summary>
        /// Gets the RowVersion column value.
        /// </summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Data.Linq.Mapping.Column(Name = "RowVersion", Storage = "_rowVersion", DbType = "timestamp NOT NULL", IsDbGenerated = true, IsVersion = true, CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 5)]
        public System.Data.Linq.Binary RowVersion
        {
            get { return _rowVersion; }
            set
            {
                if (_rowVersion != value)
                {
                    OnRowVersionChanging(value);
                    SendPropertyChanging("RowVersion");
                    _rowVersion = value;
                    SendPropertyChanged("RowVersion");
                    OnRowVersionChanged();
                }
            }
        }
        #endregion

        #region Association Mapped Properties

        private System.Data.Linq.EntitySet<Junction> _junctionList;

        /// <summary>
        /// Gets or sets the Junction association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "Left_Junction", Storage = "_junctionList", ThisKey = "Id", OtherKey = "LeftId")]
        [System.Runtime.Serialization.DataMember(Order=6, EmitDefaultValue=false)]
        public System.Data.Linq.EntitySet<Junction> JunctionList
        {
            get { return (serializing && !_junctionList.HasLoadedOrAssignedValues) ? null : _junctionList; }
            set { _junctionList.Assign(value); }
        }

        [System.Diagnostics.DebuggerNonUserCode]
        private void OnJunctionListAdd(Junction entity)
        {
            SendPropertyChanging(null);
            entity.Left = this;
            SendPropertyChanged(null);
        }

        [System.Diagnostics.DebuggerNonUserCode]
        private void OnJunctionListRemove(Junction entity)
        {
            SendPropertyChanging(null);
            entity.Left = null;
            SendPropertyChanged(null);
        }

        private System.Data.Linq.EntitySet<Right> _rightList;

        /// <summary>
        /// Gets or sets the Many To Many RightList list.
        /// </summary>
        /// <value>The RightList list.</value>
        public System.Data.Linq.EntitySet<Right> RightList
        {
            get
            {
                if (serializing)
                    return null;

                if (_rightList == null)
                {
                    _rightList = new System.Data.Linq.EntitySet<Right>(OnRightListAdd, OnRightListRemove);
                    _rightList.SetSource(JunctionList.Select(c => c.Right));
                }
                return _rightList;
            }
            set
            {
                _rightList.Assign(value);
            }
        }

        [System.Diagnostics.DebuggerNonUserCode]
        private void OnRightListAdd(Right entity)
        {
            SendPropertyChanging(null);
            JunctionList.Add(new Junction { Left = this, Right = entity });
            SendPropertyChanged(null);
        }

        [System.Diagnostics.DebuggerNonUserCode]
        private void OnRightListRemove(Right entity)
        {
            SendPropertyChanging(null);
            var junction = JunctionList.FirstOrDefault(c => c.LeftId == Id
                && c.RightId == entity.Id);
            JunctionList.Remove( junction);
            SendPropertyChanged(null);
        }

        #endregion

        #region Extensibility Method Definitions
        /// <summary>Called by the static constructor to add shared rules.</summary>
        static partial void AddSharedRules();
        /// <summary>Called when this instance is loaded.</summary>
        partial void OnLoaded();
        /// <summary>Called when this instance is being saved.</summary>
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        /// <summary>Called when this instance is created.</summary>
        partial void OnCreated();
        /// <summary>Called when <see cref="Id"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnIdChanging(int value);
        /// <summary>Called after <see cref="Id"/> has Changed.</summary>
        partial void OnIdChanged();
        /// <summary>Called when <see cref="Name"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnNameChanging(string value);
        /// <summary>Called after <see cref="Name"/> has Changed.</summary>
        partial void OnNameChanged();
        /// <summary>Called when <see cref="CreatedDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnCreatedDateChanging(System.DateTime value);
        /// <summary>Called after <see cref="CreatedDate"/> has Changed.</summary>
        partial void OnCreatedDateChanged();
        /// <summary>Called when <see cref="ModifiedDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnModifiedDateChanging(System.DateTime value);
        /// <summary>Called after <see cref="ModifiedDate"/> has Changed.</summary>
        partial void OnModifiedDateChanged();
        /// <summary>Called when <see cref="RowVersion"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnRowVersionChanging(System.Data.Linq.Binary value);
        /// <summary>Called after <see cref="RowVersion"/> has Changed.</summary>
        partial void OnRowVersionChanged();

        #endregion

        #region Serialization
        private bool serializing;

        /// <summary>
        /// Called when serializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public void OnSerializing(System.Runtime.Serialization.StreamingContext context) {
            serializing = true;
        }

        /// <summary>
        /// Called when serialized.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerialized]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public void OnSerialized(System.Runtime.Serialization.StreamingContext context) {
            serializing = false;
        }

        /// <summary>
        /// Called when deserializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnDeserializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public void OnDeserializing(System.Runtime.Serialization.StreamingContext context) {
            Initialize();
        }
        #endregion

        #region Clone
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        object ICloneable.Clone()
        {
            var serializer = new System.Runtime.Serialization.DataContractSerializer(GetType());
            using (var ms = new System.IO.MemoryStream())
            {
                serializer.WriteObject(ms, this);
                ms.Position = 0;
                return serializer.ReadObject(ms);
            }
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        /// <remarks>
        /// Only loaded <see cref="T:System.Data.Linq.EntityRef`1"/> and <see cref="T:System.Data.Linq.EntitySet`1" /> child accessions will be cloned.
        /// </remarks>
        public Left Clone()
        {
            return (Left)((ICloneable)this).Clone();
        }
        #endregion

        #region Detach Methods
        /// <summary>
        /// Detach this instance from the <see cref="System.Data.Linq.DataContext"/>.
        /// </summary>
        /// <remarks>
        /// Detaching the entity will stop all lazy loading and allow it to be added to another <see cref="System.Data.Linq.DataContext"/>.
        /// </remarks>
        public override void Detach()
        {
            if (!IsAttached())
                return;

            base.Detach();
            _junctionList = Detach(_junctionList, OnJunctionListAdd, OnJunctionListRemove);
        }
        #endregion
    }
}

