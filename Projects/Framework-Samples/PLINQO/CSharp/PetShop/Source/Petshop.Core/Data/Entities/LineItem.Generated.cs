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

namespace PetShop.Core.Data
{
    /// <summary>
    /// The class representing the dbo.LineItem table.
    /// </summary>
    [System.Data.Linq.Mapping.Table(Name="dbo.LineItem")]
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(Metadata))]
    [System.Data.Services.Common.DataServiceKey("OrderId", "LineNum")]
    [System.Diagnostics.DebuggerDisplay("OrderId: {OrderId}, LineNum: {LineNum}")]
    public partial class LineItem
        : LinqEntityBase, ICloneable
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="LineItem"/> class.
        /// </summary>
        static LineItem()
        {
            CodeSmith.Data.Rules.RuleManager.AddShared<LineItem>();
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItem"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        public LineItem()
        {
            OnCreated();
            Initialize();
        }

        private void Initialize()
        {
            _order = default(System.Data.Linq.EntityRef<Order>);
        }
        #endregion

        #region Column Mapped Properties

        private int _orderId;

        /// <summary>
        /// Gets or sets the OrderId column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "OrderId", Storage = "_orderId", DbType = "int NOT NULL", IsPrimaryKey = true, CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 1)]
        public int OrderId
        {
            get { return _orderId; }
            set
            {
                if (_orderId != value)
                {
                    if (_order.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnOrderIdChanging(value);
                    SendPropertyChanging("OrderId");
                    _orderId = value;
                    SendPropertyChanged("OrderId");
                    OnOrderIdChanged();
                }
            }
        }

        private int _lineNum;

        /// <summary>
        /// Gets or sets the LineNum column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "LineNum", Storage = "_lineNum", DbType = "int NOT NULL", IsPrimaryKey = true, CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 2)]
        public int LineNum
        {
            get { return _lineNum; }
            set
            {
                if (_lineNum != value)
                {
                    OnLineNumChanging(value);
                    SendPropertyChanging("LineNum");
                    _lineNum = value;
                    SendPropertyChanged("LineNum");
                    OnLineNumChanged();
                }
            }
        }

        private string _itemId;

        /// <summary>
        /// Gets or sets the ItemId column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "ItemId", Storage = "_itemId", DbType = "varchar(10) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.Runtime.Serialization.DataMember(Order = 3)]
        public string ItemId
        {
            get { return _itemId; }
            set
            {
                if (_itemId != value)
                {
                    OnItemIdChanging(value);
                    SendPropertyChanging("ItemId");
                    _itemId = value;
                    SendPropertyChanged("ItemId");
                    OnItemIdChanged();
                }
            }
        }

        private int _quantity;

        /// <summary>
        /// Gets or sets the Quantity column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Quantity", Storage = "_quantity", DbType = "int NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 4)]
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (_quantity != value)
                {
                    OnQuantityChanging(value);
                    SendPropertyChanging("Quantity");
                    _quantity = value;
                    SendPropertyChanged("Quantity");
                    OnQuantityChanged();
                }
            }
        }

        private decimal _unitPrice;

        /// <summary>
        /// Gets or sets the UnitPrice column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "UnitPrice", Storage = "_unitPrice", DbType = "decimal(10,2) NOT NULL", CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 5)]
        public decimal UnitPrice
        {
            get { return _unitPrice; }
            set
            {
                if (_unitPrice != value)
                {
                    OnUnitPriceChanging(value);
                    SendPropertyChanging("UnitPrice");
                    _unitPrice = value;
                    SendPropertyChanged("UnitPrice");
                    OnUnitPriceChanged();
                }
            }
        }
        #endregion

        #region Association Mapped Properties

        private System.Data.Linq.EntityRef<Order> _order;

        /// <summary>
        /// Gets or sets the Order association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "Order_LineItem", Storage = "_order", ThisKey = "OrderId", OtherKey = "OrderId", IsUnique = true, IsForeignKey = true)]
        [System.Runtime.Serialization.DataMember(Order = 6, EmitDefaultValue = false)]
        public Order Order
        {
            get { return (serializing && !_order.HasLoadedOrAssignedValue) ? null : _order.Entity; }
            set
            {
                Order previousValue = _order.Entity;
                if (previousValue != value || _order.HasLoadedOrAssignedValue == false)
                {
                    OnOrderChanging(value);
                    SendPropertyChanging("Order");
                    if (previousValue != null)
                    {
                        _order.Entity = null;
                        previousValue.LineItemList.Remove(this);
                    }
                    _order.Entity = value;
                    if (value != null)
                    {
                        value.LineItemList.Add(this);
                        _orderId = value.OrderId;
                    }
                    else
                    {
                        _orderId = default(int);
                    }
                    SendPropertyChanged("Order");
                    OnOrderChanged();
                }
            }
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
        /// <summary>Called when <see cref="OrderId"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnOrderIdChanging(int value);
        /// <summary>Called after <see cref="OrderId"/> has Changed.</summary>
        partial void OnOrderIdChanged();
        /// <summary>Called when <see cref="LineNum"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnLineNumChanging(int value);
        /// <summary>Called after <see cref="LineNum"/> has Changed.</summary>
        partial void OnLineNumChanged();
        /// <summary>Called when <see cref="ItemId"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnItemIdChanging(string value);
        /// <summary>Called after <see cref="ItemId"/> has Changed.</summary>
        partial void OnItemIdChanged();
        /// <summary>Called when <see cref="Quantity"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnQuantityChanging(int value);
        /// <summary>Called after <see cref="Quantity"/> has Changed.</summary>
        partial void OnQuantityChanged();
        /// <summary>Called when <see cref="UnitPrice"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnUnitPriceChanging(decimal value);
        /// <summary>Called after <see cref="UnitPrice"/> has Changed.</summary>
        partial void OnUnitPriceChanged();
        /// <summary>Called when <see cref="Order"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnOrderChanging(Order value);
        /// <summary>Called after <see cref="Order"/> has Changed.</summary>
        partial void OnOrderChanged();

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
        public LineItem Clone()
        {
            return (LineItem)((ICloneable)this).Clone();
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
            _order = Detach(_order);
        }
        #endregion
    }
}
