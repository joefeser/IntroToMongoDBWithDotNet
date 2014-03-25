using System;

using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Validation;
using Mindscape.LightSpeed.Linq;

namespace Commerce.Data
{
  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table(IdColumnName="CustomerId")]
  public partial class Customer : Entity<int>
  {
    #region Fields
  
    #pragma warning disable 169
    [ValidatePresence]
    [ValidateLength(0, 50)]
    private string _firstName;
    [ValidatePresence]
    [ValidateLength(0, 50)]
    private string _lastName;
    [ValidatePresence]
    [ValidateLength(0, 75)]
    private string _address1;
    [ValidateLength(0, 75)]
    private string _address2;
    [ValidatePresence]
    [ValidateLength(0, 75)]
    private string _city;
    [ValidatePresence]
    [ValidateLength(0, 50)]
    private string _stateOrProvince;
    [ValidatePresence]
    [ValidateLength(0, 50)]
    private string _country;
    [ValidatePresence]
    [ValidateEmailAddress]
    [ValidateLength(0, 75)]
    private string _email;
    [ValidateLength(0, 25)]
    private string _phone;
    #pragma warning restore 169

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the FirstName entity attribute.</summary>
    public const string FirstNameField = "FirstName";
    /// <summary>Identifies the LastName entity attribute.</summary>
    public const string LastNameField = "LastName";
    /// <summary>Identifies the Address1 entity attribute.</summary>
    public const string Address1Field = "Address1";
    /// <summary>Identifies the Address2 entity attribute.</summary>
    public const string Address2Field = "Address2";
    /// <summary>Identifies the City entity attribute.</summary>
    public const string CityField = "City";
    /// <summary>Identifies the StateOrProvince entity attribute.</summary>
    public const string StateOrProvinceField = "StateOrProvince";
    /// <summary>Identifies the Country entity attribute.</summary>
    public const string CountryField = "Country";
    /// <summary>Identifies the Email entity attribute.</summary>
    public const string EmailField = "Email";
    /// <summary>Identifies the Phone entity attribute.</summary>
    public const string PhoneField = "Phone";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Customer")]
    private readonly EntityCollection<Order> _ordersByCustomer = new EntityCollection<Order>();
    [ReverseAssociation("ShipTo")]
    private readonly EntityCollection<Order> _ordersByShipTo = new EntityCollection<Order>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Order> OrdersByCustomer
    {
      get { return Get(_ordersByCustomer); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Order> OrdersByShipTo
    {
      get { return Get(_ordersByShipTo); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public string FirstName
    {
      get { return Get(ref _firstName, "FirstName"); }
      set { Set(ref _firstName, value, "FirstName"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string LastName
    {
      get { return Get(ref _lastName, "LastName"); }
      set { Set(ref _lastName, value, "LastName"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Address1
    {
      get { return Get(ref _address1, "Address1"); }
      set { Set(ref _address1, value, "Address1"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Address2
    {
      get { return Get(ref _address2, "Address2"); }
      set { Set(ref _address2, value, "Address2"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string City
    {
      get { return Get(ref _city, "City"); }
      set { Set(ref _city, value, "City"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string StateOrProvince
    {
      get { return Get(ref _stateOrProvince, "StateOrProvince"); }
      set { Set(ref _stateOrProvince, value, "StateOrProvince"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Country
    {
      get { return Get(ref _country, "Country"); }
      set { Set(ref _country, value, "Country"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Email
    {
      get { return Get(ref _email, "Email"); }
      set { Set(ref _email, value, "Email"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Phone
    {
      get { return Get(ref _phone, "Phone"); }
      set { Set(ref _phone, value, "Phone"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table(IdColumnName="ProductId")]
  public partial class Product : Entity<int>
  {
    #region Fields
  
    #pragma warning disable 169
    private decimal _buyItNowPrice;
    [ValidateLength(0, 50)]
    private string _esrbAgeRating;
    private string _feature;
    [ValidateLength(0, 50)]
    private string _format;
    [ValidateLength(0, 75)]
    private string _genre;
    [ValidateLength(0, 75)]
    private string _hardwarePlatform;
    [ValidateLength(0, 100)]
    private string _largeImage;
    private decimal _listPrice;
    [ValidateLength(0, 75)]
    private string _manufacturer;
    [ValidateLength(0, 50)]
    private string _model;
    private decimal _height;
    private decimal _length;
    private decimal _width;
    private decimal _weight;
    [ValidateLength(0, 50)]
    private string _partNumber;
    [ValidateLength(0, 50)]
    private string _productGroup;
    [ValidatePresence]
    [ValidateLength(0, 250)]
    private string _title;
    [ValidatePresence]
    [ValidateLength(0, 30)]
    private string _asin;
    private System.Nullable<int> _categoryId;
    private System.Nullable<int> _publisherId;
    #pragma warning restore 169

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the BuyItNowPrice entity attribute.</summary>
    public const string BuyItNowPriceField = "BuyItNowPrice";
    /// <summary>Identifies the EsrbAgeRating entity attribute.</summary>
    public const string EsrbAgeRatingField = "EsrbAgeRating";
    /// <summary>Identifies the Feature entity attribute.</summary>
    public const string FeatureField = "Feature";
    /// <summary>Identifies the Format entity attribute.</summary>
    public const string FormatField = "Format";
    /// <summary>Identifies the Genre entity attribute.</summary>
    public const string GenreField = "Genre";
    /// <summary>Identifies the HardwarePlatform entity attribute.</summary>
    public const string HardwarePlatformField = "HardwarePlatform";
    /// <summary>Identifies the LargeImage entity attribute.</summary>
    public const string LargeImageField = "LargeImage";
    /// <summary>Identifies the ListPrice entity attribute.</summary>
    public const string ListPriceField = "ListPrice";
    /// <summary>Identifies the Manufacturer entity attribute.</summary>
    public const string ManufacturerField = "Manufacturer";
    /// <summary>Identifies the Model entity attribute.</summary>
    public const string ModelField = "Model";
    /// <summary>Identifies the Height entity attribute.</summary>
    public const string HeightField = "Height";
    /// <summary>Identifies the Length entity attribute.</summary>
    public const string LengthField = "Length";
    /// <summary>Identifies the Width entity attribute.</summary>
    public const string WidthField = "Width";
    /// <summary>Identifies the Weight entity attribute.</summary>
    public const string WeightField = "Weight";
    /// <summary>Identifies the PartNumber entity attribute.</summary>
    public const string PartNumberField = "PartNumber";
    /// <summary>Identifies the ProductGroup entity attribute.</summary>
    public const string ProductGroupField = "ProductGroup";
    /// <summary>Identifies the Title entity attribute.</summary>
    public const string TitleField = "Title";
    /// <summary>Identifies the Asin entity attribute.</summary>
    public const string AsinField = "Asin";
    /// <summary>Identifies the CategoryId entity attribute.</summary>
    public const string CategoryIdField = "CategoryId";
    /// <summary>Identifies the PublisherId entity attribute.</summary>
    public const string PublisherIdField = "PublisherId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Product")]
    private readonly EntityCollection<OrderDetail> _orderDetails = new EntityCollection<OrderDetail>();
    [ReverseAssociation("Products")]
    private readonly EntityHolder<Category> _category = new EntityHolder<Category>();
    [ReverseAssociation("Products")]
    private readonly EntityHolder<Publisher> _publisher = new EntityHolder<Publisher>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<OrderDetail> OrderDetails
    {
      get { return Get(_orderDetails); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public Category Category
    {
      get { return Get(_category); }
      set { Set(_category, value); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public Publisher Publisher
    {
      get { return Get(_publisher); }
      set { Set(_publisher, value); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public decimal BuyItNowPrice
    {
      get { return Get(ref _buyItNowPrice, "BuyItNowPrice"); }
      set { Set(ref _buyItNowPrice, value, "BuyItNowPrice"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string EsrbAgeRating
    {
      get { return Get(ref _esrbAgeRating, "EsrbAgeRating"); }
      set { Set(ref _esrbAgeRating, value, "EsrbAgeRating"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Feature
    {
      get { return Get(ref _feature, "Feature"); }
      set { Set(ref _feature, value, "Feature"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Format
    {
      get { return Get(ref _format, "Format"); }
      set { Set(ref _format, value, "Format"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Genre
    {
      get { return Get(ref _genre, "Genre"); }
      set { Set(ref _genre, value, "Genre"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string HardwarePlatform
    {
      get { return Get(ref _hardwarePlatform, "HardwarePlatform"); }
      set { Set(ref _hardwarePlatform, value, "HardwarePlatform"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string LargeImage
    {
      get { return Get(ref _largeImage, "LargeImage"); }
      set { Set(ref _largeImage, value, "LargeImage"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public decimal ListPrice
    {
      get { return Get(ref _listPrice, "ListPrice"); }
      set { Set(ref _listPrice, value, "ListPrice"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Manufacturer
    {
      get { return Get(ref _manufacturer, "Manufacturer"); }
      set { Set(ref _manufacturer, value, "Manufacturer"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Model
    {
      get { return Get(ref _model, "Model"); }
      set { Set(ref _model, value, "Model"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public decimal Height
    {
      get { return Get(ref _height, "Height"); }
      set { Set(ref _height, value, "Height"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public decimal Length
    {
      get { return Get(ref _length, "Length"); }
      set { Set(ref _length, value, "Length"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public decimal Width
    {
      get { return Get(ref _width, "Width"); }
      set { Set(ref _width, value, "Width"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public decimal Weight
    {
      get { return Get(ref _weight, "Weight"); }
      set { Set(ref _weight, value, "Weight"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string PartNumber
    {
      get { return Get(ref _partNumber, "PartNumber"); }
      set { Set(ref _partNumber, value, "PartNumber"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string ProductGroup
    {
      get { return Get(ref _productGroup, "ProductGroup"); }
      set { Set(ref _productGroup, value, "ProductGroup"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Title
    {
      get { return Get(ref _title, "Title"); }
      set { Set(ref _title, value, "Title"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string Asin
    {
      get { return Get(ref _asin, "Asin"); }
      set { Set(ref _asin, value, "Asin"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Category" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<int> CategoryId
    {
      get { return Get(ref _categoryId, "CategoryId"); }
      set { Set(ref _categoryId, value, "CategoryId"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Publisher" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<int> PublisherId
    {
      get { return Get(ref _publisherId, "PublisherId"); }
      set { Set(ref _publisherId, value, "PublisherId"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table(IdColumnName="OrderDetailId")]
  public partial class OrderDetail : Entity<int>
  {
    #region Fields
  
    #pragma warning disable 169
    private int _orderedQuantity;
    private int _quantity;
    private decimal _unitPrice;
    private int _productId;
    private int _orderId;
    #pragma warning restore 169

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the OrderedQuantity entity attribute.</summary>
    public const string OrderedQuantityField = "OrderedQuantity";
    /// <summary>Identifies the Quantity entity attribute.</summary>
    public const string QuantityField = "Quantity";
    /// <summary>Identifies the UnitPrice entity attribute.</summary>
    public const string UnitPriceField = "UnitPrice";
    /// <summary>Identifies the ProductId entity attribute.</summary>
    public const string ProductIdField = "ProductId";
    /// <summary>Identifies the OrderId entity attribute.</summary>
    public const string OrderIdField = "OrderId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("OrderDetails")]
    private readonly EntityHolder<Product> _product = new EntityHolder<Product>();
    [ReverseAssociation("OrderDetails")]
    private readonly EntityHolder<Order> _order = new EntityHolder<Order>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public Product Product
    {
      get { return Get(_product); }
      set { Set(_product, value); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public Order Order
    {
      get { return Get(_order); }
      set { Set(_order, value); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public int OrderedQuantity
    {
      get { return Get(ref _orderedQuantity, "OrderedQuantity"); }
      set { Set(ref _orderedQuantity, value, "OrderedQuantity"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public int Quantity
    {
      get { return Get(ref _quantity, "Quantity"); }
      set { Set(ref _quantity, value, "Quantity"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public decimal UnitPrice
    {
      get { return Get(ref _unitPrice, "UnitPrice"); }
      set { Set(ref _unitPrice, value, "UnitPrice"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Product" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public int ProductId
    {
      get { return Get(ref _productId, "ProductId"); }
      set { Set(ref _productId, value, "ProductId"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Order" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public int OrderId
    {
      get { return Get(ref _orderId, "OrderId"); }
      set { Set(ref _orderId, value, "OrderId"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table("Orders", IdColumnName="OrderId")]
  public partial class Order : Entity<int>
  {
    #region Fields
  
    #pragma warning disable 169
    private System.DateTime _orderDate;
    private decimal _orderTotal;
    private byte _status;
    private int _customerId;
    [Column("ShipTo")]
    private int _shipToId;
    #pragma warning restore 169

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the OrderDate entity attribute.</summary>
    public const string OrderDateField = "OrderDate";
    /// <summary>Identifies the OrderTotal entity attribute.</summary>
    public const string OrderTotalField = "OrderTotal";
    /// <summary>Identifies the Status entity attribute.</summary>
    public const string StatusField = "Status";
    /// <summary>Identifies the CustomerId entity attribute.</summary>
    public const string CustomerIdField = "CustomerId";
    /// <summary>Identifies the ShipToId entity attribute.</summary>
    public const string ShipToIdField = "ShipToId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Order")]
    private readonly EntityCollection<OrderDetail> _orderDetails = new EntityCollection<OrderDetail>();
    [ReverseAssociation("OrdersByCustomer")]
    private readonly EntityHolder<Customer> _customer = new EntityHolder<Customer>();
    [ReverseAssociation("OrdersByShipTo")]
    private readonly EntityHolder<Customer> _shipTo = new EntityHolder<Customer>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<OrderDetail> OrderDetails
    {
      get { return Get(_orderDetails); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public Customer Customer
    {
      get { return Get(_customer); }
      set { Set(_customer, value); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public Customer ShipTo
    {
      get { return Get(_shipTo); }
      set { Set(_shipTo, value); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public System.DateTime OrderDate
    {
      get { return Get(ref _orderDate, "OrderDate"); }
      set { Set(ref _orderDate, value, "OrderDate"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public decimal OrderTotal
    {
      get { return Get(ref _orderTotal, "OrderTotal"); }
      set { Set(ref _orderTotal, value, "OrderTotal"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public byte Status
    {
      get { return Get(ref _status, "Status"); }
      set { Set(ref _status, value, "Status"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Customer" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public int CustomerId
    {
      get { return Get(ref _customerId, "CustomerId"); }
      set { Set(ref _customerId, value, "CustomerId"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="ShipTo" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public int ShipToId
    {
      get { return Get(ref _shipToId, "ShipToId"); }
      set { Set(ref _shipToId, value, "ShipToId"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table(IdColumnName="CategoryId")]
  public partial class Category : Entity<int>
  {
    #region Fields
  
    #pragma warning disable 169
    [ValidatePresence]
    [ValidateLength(0, 75)]
    private string _categoryName;
    #pragma warning restore 169

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the CategoryName entity attribute.</summary>
    public const string CategoryNameField = "CategoryName";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Category")]
    private readonly EntityCollection<Product> _products = new EntityCollection<Product>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Product> Products
    {
      get { return Get(_products); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public string CategoryName
    {
      get { return Get(ref _categoryName, "CategoryName"); }
      set { Set(ref _categoryName, value, "CategoryName"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table(IdColumnName="PublisherId")]
  public partial class Publisher : Entity<int>
  {
    #region Fields
  
    #pragma warning disable 169
    [ValidatePresence]
    [ValidateLength(0, 75)]
    private string _publisherName;
    #pragma warning restore 169

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the PublisherName entity attribute.</summary>
    public const string PublisherNameField = "PublisherName";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Publisher")]
    private readonly EntityCollection<Product> _products = new EntityCollection<Product>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Product> Products
    {
      get { return Get(_products); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public string PublisherName
    {
      get { return Get(ref _publisherName, "PublisherName"); }
      set { Set(ref _publisherName, value, "PublisherName"); }
    }

    #endregion
  }




  /// <summary>
  /// Provides a strong-typed unit of work for working with the CommerceModel model.
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  public partial class CommerceModelUnitOfWork : Mindscape.LightSpeed.UnitOfWork
  {

    public System.Linq.IQueryable<Customer> Customers
    {
      get { return this.Query<Customer>(); }
    }
    
    public System.Linq.IQueryable<Product> Products
    {
      get { return this.Query<Product>(); }
    }
    
    public System.Linq.IQueryable<OrderDetail> OrderDetails
    {
      get { return this.Query<OrderDetail>(); }
    }
    
    public System.Linq.IQueryable<Order> Orders
    {
      get { return this.Query<Order>(); }
    }
    
    public System.Linq.IQueryable<Category> Categories
    {
      get { return this.Query<Category>(); }
    }
    
    public System.Linq.IQueryable<Publisher> Publishers
    {
      get { return this.Query<Publisher>(); }
    }
    
  }

}
