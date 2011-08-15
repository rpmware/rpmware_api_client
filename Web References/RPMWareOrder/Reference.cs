using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using RPMWare.Api.Client.Properties;

#pragma warning disable 1591

namespace RPMWare.Api.Client.RPMWareOrder
{
	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[WebServiceBinding(Name = "OrderSoap", Namespace = "https://secure.rpmware.com/api")]
	[XmlInclude(typeof (ApiModelBase))]
	[XmlInclude(typeof (object[]))]
	public class Order : SoapHttpClientProtocol
	{
		private SendOrPostCallback AddHistoryOperationCompleted;

		private SendOrPostCallback AddLineItemOperationCompleted;

		private SendOrPostCallback AddTrackingNumberOperationCompleted;

		private SendOrPostCallback GetOrderIdsSinceLastOrderIdOperationCompleted;
		private SendOrPostCallback GetOrderOperationCompleted;

		private SendOrPostCallback GetOrdersByCustomerOperationCompleted;
		private SendOrPostCallback GetOrdersOperationCompleted;

		private SendOrPostCallback GetOrdersSinceLastOrderIdOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		/// <remarks />
		public Order()
		{
			Url = Settings.Default.RPMWare_Api_Client_RPMWareOrder_Order;
			if (IsLocalFileSystemWebService(Url))
			{
				UseDefaultCredentials = true;
				useDefaultCredentialsSetExplicitly = false;
			}
			else
			{
				useDefaultCredentialsSetExplicitly = true;
			}
		}

		public new string Url
		{
			get { return base.Url; }
			set
			{
				if (((IsLocalFileSystemWebService(base.Url) && (useDefaultCredentialsSetExplicitly == false)) && (IsLocalFileSystemWebService(value) == false)))
				{
					base.UseDefaultCredentials = false;
				}
				base.Url = value;
			}
		}

		public new bool UseDefaultCredentials
		{
			get { return base.UseDefaultCredentials; }
			set
			{
				base.UseDefaultCredentials = value;
				useDefaultCredentialsSetExplicitly = true;
			}
		}

		/// <remarks />
		public event AddHistoryCompletedEventHandler AddHistoryCompleted;

		/// <remarks />
		public event AddLineItemCompletedEventHandler AddLineItemCompleted;

		/// <remarks />
		public event AddTrackingNumberCompletedEventHandler AddTrackingNumberCompleted;

		/// <remarks />
		public event GetOrderCompletedEventHandler GetOrderCompleted;

		/// <remarks />
		public event GetOrderIdsSinceLastOrderIdCompletedEventHandler GetOrderIdsSinceLastOrderIdCompleted;

		/// <remarks />
		public event GetOrdersCompletedEventHandler GetOrdersCompleted;

		/// <remarks />
		public event GetOrdersByCustomerCompletedEventHandler GetOrdersByCustomerCompleted;

		/// <remarks />
		public event GetOrdersSinceLastOrderIdCompletedEventHandler GetOrdersSinceLastOrderIdCompleted;

		/// <remarks />
		[SoapDocumentMethod("https://secure.rpmware.com/api/AddHistory", RequestNamespace = "https://secure.rpmware.com/api", ResponseNamespace = "https://secure.rpmware.com/api",
			Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public Result AddHistory(string apiToken, int orderId, string note)
		{
			object[] results = Invoke("AddHistory", new object[] {apiToken, orderId, note});
			return ((Result) (results[0]));
		}

		/// <remarks />
		public void AddHistoryAsync(string apiToken, int orderId, string note)
		{
			AddHistoryAsync(apiToken, orderId, note, null);
		}

		/// <remarks />
		public void AddHistoryAsync(string apiToken, int orderId, string note, object userState)
		{
			if ((AddHistoryOperationCompleted == null))
			{
				AddHistoryOperationCompleted = new SendOrPostCallback(OnAddHistoryOperationCompleted);
			}
			InvokeAsync("AddHistory", new object[] {apiToken, orderId, note}, AddHistoryOperationCompleted, userState);
		}

		private void OnAddHistoryOperationCompleted(object arg)
		{
			if ((AddHistoryCompleted != null))
			{
				var invokeArgs = ((InvokeCompletedEventArgs) (arg));
				AddHistoryCompleted(this, new AddHistoryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}

		/// <remarks />
		[SoapDocumentMethod("https://secure.rpmware.com/api/AddLineItem", RequestNamespace = "https://secure.rpmware.com/api", ResponseNamespace = "https://secure.rpmware.com/api",
			Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public Result AddLineItem(string apiToken, int orderId, int itemId, decimal price, int quantity)
		{
			object[] results = Invoke("AddLineItem", new object[] {apiToken, orderId, itemId, price, quantity});
			return ((Result) (results[0]));
		}

		/// <remarks />
		public void AddLineItemAsync(string apiToken, int orderId, int itemId, decimal price, int quantity)
		{
			AddLineItemAsync(apiToken, orderId, itemId, price, quantity, null);
		}

		/// <remarks />
		public void AddLineItemAsync(string apiToken, int orderId, int itemId, decimal price, int quantity, object userState)
		{
			if ((AddLineItemOperationCompleted == null))
			{
				AddLineItemOperationCompleted = new SendOrPostCallback(OnAddLineItemOperationCompleted);
			}
			InvokeAsync("AddLineItem", new object[] {apiToken, orderId, itemId, price, quantity}, AddLineItemOperationCompleted, userState);
		}

		private void OnAddLineItemOperationCompleted(object arg)
		{
			if ((AddLineItemCompleted != null))
			{
				var invokeArgs = ((InvokeCompletedEventArgs) (arg));
				AddLineItemCompleted(this, new AddLineItemCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}

		/// <remarks />
		[SoapDocumentMethod("https://secure.rpmware.com/api/AddTrackingNumber", RequestNamespace = "https://secure.rpmware.com/api", ResponseNamespace = "https://secure.rpmware.com/api",
			Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public Result AddTrackingNumber(string apiToken, int orderId, string shippingMethod, string trackingNumber, string notes)
		{
			object[] results = Invoke("AddTrackingNumber", new object[] {apiToken, orderId, shippingMethod, trackingNumber, notes});
			return ((Result) (results[0]));
		}

		/// <remarks />
		public void AddTrackingNumberAsync(string apiToken, int orderId, string shippingMethod, string trackingNumber, string notes)
		{
			AddTrackingNumberAsync(apiToken, orderId, shippingMethod, trackingNumber, notes, null);
		}

		/// <remarks />
		public void AddTrackingNumberAsync(string apiToken, int orderId, string shippingMethod, string trackingNumber, string notes, object userState)
		{
			if ((AddTrackingNumberOperationCompleted == null))
			{
				AddTrackingNumberOperationCompleted = new SendOrPostCallback(OnAddTrackingNumberOperationCompleted);
			}
			InvokeAsync("AddTrackingNumber", new object[] {apiToken, orderId, shippingMethod, trackingNumber, notes}, AddTrackingNumberOperationCompleted, userState);
		}

		private void OnAddTrackingNumberOperationCompleted(object arg)
		{
			if ((AddTrackingNumberCompleted != null))
			{
				var invokeArgs = ((InvokeCompletedEventArgs) (arg));
				AddTrackingNumberCompleted(this, new AddTrackingNumberCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}

		/// <remarks />
		[SoapDocumentMethod("https://secure.rpmware.com/api/GetOrder", RequestNamespace = "https://secure.rpmware.com/api", ResponseNamespace = "https://secure.rpmware.com/api",
			Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public Result GetOrder(string apiToken, int id)
		{
			object[] results = Invoke("GetOrder", new object[] {apiToken, id});
			return ((Result) (results[0]));
		}

		/// <remarks />
		public void GetOrderAsync(string apiToken, int id)
		{
			GetOrderAsync(apiToken, id, null);
		}

		/// <remarks />
		public void GetOrderAsync(string apiToken, int id, object userState)
		{
			if ((GetOrderOperationCompleted == null))
			{
				GetOrderOperationCompleted = new SendOrPostCallback(OnGetOrderOperationCompleted);
			}
			InvokeAsync("GetOrder", new object[] {apiToken, id}, GetOrderOperationCompleted, userState);
		}

		private void OnGetOrderOperationCompleted(object arg)
		{
			if ((GetOrderCompleted != null))
			{
				var invokeArgs = ((InvokeCompletedEventArgs) (arg));
				GetOrderCompleted(this, new GetOrderCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}

		/// <remarks />
		[SoapDocumentMethod("https://secure.rpmware.com/api/GetOrderIdsSinceLastOrderId", RequestNamespace = "https://secure.rpmware.com/api",
			ResponseNamespace = "https://secure.rpmware.com/api", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public Result GetOrderIdsSinceLastOrderId(string apiToken, int lastOrderId)
		{
			object[] results = Invoke("GetOrderIdsSinceLastOrderId", new object[] {apiToken, lastOrderId});
			return ((Result) (results[0]));
		}

		/// <remarks />
		public void GetOrderIdsSinceLastOrderIdAsync(string apiToken, int lastOrderId)
		{
			GetOrderIdsSinceLastOrderIdAsync(apiToken, lastOrderId, null);
		}

		/// <remarks />
		public void GetOrderIdsSinceLastOrderIdAsync(string apiToken, int lastOrderId, object userState)
		{
			if ((GetOrderIdsSinceLastOrderIdOperationCompleted == null))
			{
				GetOrderIdsSinceLastOrderIdOperationCompleted = new SendOrPostCallback(OnGetOrderIdsSinceLastOrderIdOperationCompleted);
			}
			InvokeAsync("GetOrderIdsSinceLastOrderId", new object[] {apiToken, lastOrderId}, GetOrderIdsSinceLastOrderIdOperationCompleted, userState);
		}

		private void OnGetOrderIdsSinceLastOrderIdOperationCompleted(object arg)
		{
			if ((GetOrderIdsSinceLastOrderIdCompleted != null))
			{
				var invokeArgs = ((InvokeCompletedEventArgs) (arg));
				GetOrderIdsSinceLastOrderIdCompleted(this, new GetOrderIdsSinceLastOrderIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}

		/// <remarks />
		[SoapDocumentMethod("https://secure.rpmware.com/api/GetOrders", RequestNamespace = "https://secure.rpmware.com/api", ResponseNamespace = "https://secure.rpmware.com/api",
			Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public Result GetOrders(string apiToken)
		{
			object[] results = Invoke("GetOrders", new object[] {apiToken});
			return ((Result) (results[0]));
		}

		/// <remarks />
		public void GetOrdersAsync(string apiToken)
		{
			GetOrdersAsync(apiToken, null);
		}

		/// <remarks />
		public void GetOrdersAsync(string apiToken, object userState)
		{
			if ((GetOrdersOperationCompleted == null))
			{
				GetOrdersOperationCompleted = new SendOrPostCallback(OnGetOrdersOperationCompleted);
			}
			InvokeAsync("GetOrders", new object[] {apiToken}, GetOrdersOperationCompleted, userState);
		}

		private void OnGetOrdersOperationCompleted(object arg)
		{
			if ((GetOrdersCompleted != null))
			{
				var invokeArgs = ((InvokeCompletedEventArgs) (arg));
				GetOrdersCompleted(this, new GetOrdersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}

		/// <remarks />
		[SoapDocumentMethod("https://secure.rpmware.com/api/GetOrdersByCustomer", RequestNamespace = "https://secure.rpmware.com/api",
			ResponseNamespace = "https://secure.rpmware.com/api", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public Result GetOrdersByCustomer(string apiToken, int customerId)
		{
			object[] results = Invoke("GetOrdersByCustomer", new object[] {apiToken, customerId});
			return ((Result) (results[0]));
		}

		/// <remarks />
		public void GetOrdersByCustomerAsync(string apiToken, int customerId)
		{
			GetOrdersByCustomerAsync(apiToken, customerId, null);
		}

		/// <remarks />
		public void GetOrdersByCustomerAsync(string apiToken, int customerId, object userState)
		{
			if ((GetOrdersByCustomerOperationCompleted == null))
			{
				GetOrdersByCustomerOperationCompleted = new SendOrPostCallback(OnGetOrdersByCustomerOperationCompleted);
			}
			InvokeAsync("GetOrdersByCustomer", new object[] {apiToken, customerId}, GetOrdersByCustomerOperationCompleted, userState);
		}

		private void OnGetOrdersByCustomerOperationCompleted(object arg)
		{
			if ((GetOrdersByCustomerCompleted != null))
			{
				var invokeArgs = ((InvokeCompletedEventArgs) (arg));
				GetOrdersByCustomerCompleted(this, new GetOrdersByCustomerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}

		/// <remarks />
		[SoapDocumentMethod("https://secure.rpmware.com/api/GetOrdersSinceLastOrderId", RequestNamespace = "https://secure.rpmware.com/api",
			ResponseNamespace = "https://secure.rpmware.com/api", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public Result GetOrdersSinceLastOrderId(string apiToken, int lastOrderId)
		{
			object[] results = Invoke("GetOrdersSinceLastOrderId", new object[] {apiToken, lastOrderId});
			return ((Result) (results[0]));
		}

		/// <remarks />
		public void GetOrdersSinceLastOrderIdAsync(string apiToken, int lastOrderId)
		{
			GetOrdersSinceLastOrderIdAsync(apiToken, lastOrderId, null);
		}

		/// <remarks />
		public void GetOrdersSinceLastOrderIdAsync(string apiToken, int lastOrderId, object userState)
		{
			if ((GetOrdersSinceLastOrderIdOperationCompleted == null))
			{
				GetOrdersSinceLastOrderIdOperationCompleted = new SendOrPostCallback(OnGetOrdersSinceLastOrderIdOperationCompleted);
			}
			InvokeAsync("GetOrdersSinceLastOrderId", new object[] {apiToken, lastOrderId}, GetOrdersSinceLastOrderIdOperationCompleted, userState);
		}

		private void OnGetOrdersSinceLastOrderIdOperationCompleted(object arg)
		{
			if ((GetOrdersSinceLastOrderIdCompleted != null))
			{
				var invokeArgs = ((InvokeCompletedEventArgs) (arg));
				GetOrdersSinceLastOrderIdCompleted(this, new GetOrdersSinceLastOrderIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}

		/// <remarks />
		public new void CancelAsync(object userState)
		{
			base.CancelAsync(userState);
		}

		private bool IsLocalFileSystemWebService(string url)
		{
			if (((url == null) || (url == string.Empty)))
			{
				return false;
			}
			var wsUri = new Uri(url);
			if (((wsUri.Port >= 1024) && (string.Compare(wsUri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0)))
			{
				return true;
			}
			return false;
		}
	}

	/// <remarks />
	[GeneratedCode("System.Xml", "4.0.30319.225")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "https://secure.rpmware.com/api")]
	public class Result
	{
		private object dataField;

		private string messageField;

		private string successField;

		/// <remarks />
		public object Data
		{
			get { return dataField; }
			set { dataField = value; }
		}

		/// <remarks />
		public string Message
		{
			get { return messageField; }
			set { messageField = value; }
		}

		/// <remarks />
		public string Success
		{
			get { return successField; }
			set { successField = value; }
		}
	}

	/// <remarks />
	[XmlInclude(typeof (Order1))]
	[XmlInclude(typeof (Address))]
	[XmlInclude(typeof (Customer))]
	[XmlInclude(typeof (CustomerLevel))]
	[XmlInclude(typeof (OrderHistory))]
	[XmlInclude(typeof (OrderLineItem))]
	[XmlInclude(typeof (Payment))]
	[XmlInclude(typeof (OrderTracking))]
	[GeneratedCode("System.Xml", "4.0.30319.225")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "https://secure.rpmware.com/api")]
	public class ApiModelBase
	{
		private DateTime dateAddedField;

		private DateTime dateModifiedField;

		private int idField;

		/// <remarks />
		public DateTime DateAdded
		{
			get { return dateAddedField; }
			set { dateAddedField = value; }
		}

		/// <remarks />
		public DateTime DateModified
		{
			get { return dateModifiedField; }
			set { dateModifiedField = value; }
		}

		/// <remarks />
		public int Id
		{
			get { return idField; }
			set { idField = value; }
		}
	}

	/// <remarks />
	[GeneratedCode("System.Xml", "4.0.30319.225")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(TypeName = "Order", Namespace = "https://secure.rpmware.com/api")]
	public class Order1 : ApiModelBase
	{
		private Address billingAddressField;

		private string customerCommentsField;
		private Customer customerField;

		private OrderHistory[] historyField;

		private OrderLineItem[] lineItemsField;

		private int orderNoField;

		private string orderStatusField;

		private decimal orderTotalField;

		private Payment[] paymentsField;

		private Address shippingAddressField;

		private decimal shippingAmountField;

		private string shippingMethodField;

		private decimal taxAmountField;

		private OrderTracking[] trackingNumbersField;

		/// <remarks />
		public Address BillingAddress
		{
			get { return billingAddressField; }
			set { billingAddressField = value; }
		}

		/// <remarks />
		public Customer Customer
		{
			get { return customerField; }
			set { customerField = value; }
		}

		/// <remarks />
		public string CustomerComments
		{
			get { return customerCommentsField; }
			set { customerCommentsField = value; }
		}

		/// <remarks />
		public OrderHistory[] History
		{
			get { return historyField; }
			set { historyField = value; }
		}

		/// <remarks />
		public OrderLineItem[] LineItems
		{
			get { return lineItemsField; }
			set { lineItemsField = value; }
		}

		/// <remarks />
		public int OrderNo
		{
			get { return orderNoField; }
			set { orderNoField = value; }
		}

		/// <remarks />
		public string OrderStatus
		{
			get { return orderStatusField; }
			set { orderStatusField = value; }
		}

		/// <remarks />
		public decimal OrderTotal
		{
			get { return orderTotalField; }
			set { orderTotalField = value; }
		}

		/// <remarks />
		public Payment[] Payments
		{
			get { return paymentsField; }
			set { paymentsField = value; }
		}

		/// <remarks />
		public Address ShippingAddress
		{
			get { return shippingAddressField; }
			set { shippingAddressField = value; }
		}

		/// <remarks />
		public decimal ShippingAmount
		{
			get { return shippingAmountField; }
			set { shippingAmountField = value; }
		}

		/// <remarks />
		public string ShippingMethod
		{
			get { return shippingMethodField; }
			set { shippingMethodField = value; }
		}

		/// <remarks />
		public decimal TaxAmount
		{
			get { return taxAmountField; }
			set { taxAmountField = value; }
		}

		/// <remarks />
		public OrderTracking[] TrackingNumbers
		{
			get { return trackingNumbersField; }
			set { trackingNumbersField = value; }
		}
	}

	/// <remarks />
	[GeneratedCode("System.Xml", "4.0.30319.225")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "https://secure.rpmware.com/api")]
	public class Address : ApiModelBase
	{
		private string accountNameField;

		private string cityField;

		private string countryField;

		private string firstNameField;

		private string lastNameField;

		private string stateField;

		private string streetAddress1Field;

		private string streetAddress2Field;

		private string zipField;

		/// <remarks />
		public string AccountName
		{
			get { return accountNameField; }
			set { accountNameField = value; }
		}

		/// <remarks />
		public string City
		{
			get { return cityField; }
			set { cityField = value; }
		}

		/// <remarks />
		public string Country
		{
			get { return countryField; }
			set { countryField = value; }
		}

		/// <remarks />
		public string FirstName
		{
			get { return firstNameField; }
			set { firstNameField = value; }
		}

		/// <remarks />
		public string LastName
		{
			get { return lastNameField; }
			set { lastNameField = value; }
		}

		/// <remarks />
		public string State
		{
			get { return stateField; }
			set { stateField = value; }
		}

		/// <remarks />
		public string StreetAddress1
		{
			get { return streetAddress1Field; }
			set { streetAddress1Field = value; }
		}

		/// <remarks />
		public string StreetAddress2
		{
			get { return streetAddress2Field; }
			set { streetAddress2Field = value; }
		}

		/// <remarks />
		public string Zip
		{
			get { return zipField; }
			set { zipField = value; }
		}
	}

	/// <remarks />
	[GeneratedCode("System.Xml", "4.0.30319.225")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "https://secure.rpmware.com/api")]
	public class Customer : ApiModelBase
	{
		private string accountNameField;

		private Address[] addressesField;

		private CustomerLevel customerLevelField;

		private string emailField;

		private string faxField;

		private Order1[] ordersField;

		private string phone1Field;

		private string phone2Field;

		/// <remarks />
		public string AccountName
		{
			get { return accountNameField; }
			set { accountNameField = value; }
		}

		/// <remarks />
		public Address[] Addresses
		{
			get { return addressesField; }
			set { addressesField = value; }
		}

		/// <remarks />
		public CustomerLevel CustomerLevel
		{
			get { return customerLevelField; }
			set { customerLevelField = value; }
		}

		/// <remarks />
		public string Email
		{
			get { return emailField; }
			set { emailField = value; }
		}

		/// <remarks />
		public string Fax
		{
			get { return faxField; }
			set { faxField = value; }
		}

		/// <remarks />
		public Order1[] Orders
		{
			get { return ordersField; }
			set { ordersField = value; }
		}

		/// <remarks />
		public string Phone1
		{
			get { return phone1Field; }
			set { phone1Field = value; }
		}

		/// <remarks />
		public string Phone2
		{
			get { return phone2Field; }
			set { phone2Field = value; }
		}
	}

	/// <remarks />
	[GeneratedCode("System.Xml", "4.0.30319.225")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "https://secure.rpmware.com/api")]
	public class CustomerLevel : ApiModelBase
	{
		private string nameField;

		/// <remarks />
		public string Name
		{
			get { return nameField; }
			set { nameField = value; }
		}
	}

	/// <remarks />
	[GeneratedCode("System.Xml", "4.0.30319.225")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "https://secure.rpmware.com/api")]
	public class OrderHistory : ApiModelBase
	{
		private string notesField;

		/// <remarks />
		public string Notes
		{
			get { return notesField; }
			set { notesField = value; }
		}
	}

	/// <remarks />
	[GeneratedCode("System.Xml", "4.0.30319.225")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "https://secure.rpmware.com/api")]
	public class OrderLineItem : ApiModelBase
	{
		private string brandNameField;

		private decimal extendedPriceField;

		private int itemIdField;

		private string partNumberField;

		private decimal priceField;

		private string productGroupNameField;

		private int quantityField;

		/// <remarks />
		public string BrandName
		{
			get { return brandNameField; }
			set { brandNameField = value; }
		}

		/// <remarks />
		public decimal ExtendedPrice
		{
			get { return extendedPriceField; }
			set { extendedPriceField = value; }
		}

		/// <remarks />
		public int ItemId
		{
			get { return itemIdField; }
			set { itemIdField = value; }
		}

		/// <remarks />
		public string PartNumber
		{
			get { return partNumberField; }
			set { partNumberField = value; }
		}

		/// <remarks />
		public decimal Price
		{
			get { return priceField; }
			set { priceField = value; }
		}

		/// <remarks />
		public string ProductGroupName
		{
			get { return productGroupNameField; }
			set { productGroupNameField = value; }
		}

		/// <remarks />
		public int Quantity
		{
			get { return quantityField; }
			set { quantityField = value; }
		}
	}

	/// <remarks />
	[GeneratedCode("System.Xml", "4.0.30319.225")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "https://secure.rpmware.com/api")]
	public class Payment : ApiModelBase
	{
		private string authorizationNumberField;

		private int creditCardExpirationMonthField;

		private int creditCardExpirationYearField;

		private string creditCardNumberField;

		private decimal paymentAmountField;

		private string paymentStatusField;

		private string paymentTypeField;

		private string transactionNumberField;

		/// <remarks />
		public string AuthorizationNumber
		{
			get { return authorizationNumberField; }
			set { authorizationNumberField = value; }
		}

		/// <remarks />
		public int CreditCardExpirationMonth
		{
			get { return creditCardExpirationMonthField; }
			set { creditCardExpirationMonthField = value; }
		}

		/// <remarks />
		public int CreditCardExpirationYear
		{
			get { return creditCardExpirationYearField; }
			set { creditCardExpirationYearField = value; }
		}

		/// <remarks />
		public string CreditCardNumber
		{
			get { return creditCardNumberField; }
			set { creditCardNumberField = value; }
		}

		/// <remarks />
		public decimal PaymentAmount
		{
			get { return paymentAmountField; }
			set { paymentAmountField = value; }
		}

		/// <remarks />
		public string PaymentStatus
		{
			get { return paymentStatusField; }
			set { paymentStatusField = value; }
		}

		/// <remarks />
		public string PaymentType
		{
			get { return paymentTypeField; }
			set { paymentTypeField = value; }
		}

		/// <remarks />
		public string TransactionNumber
		{
			get { return transactionNumberField; }
			set { transactionNumberField = value; }
		}
	}

	/// <remarks />
	[GeneratedCode("System.Xml", "4.0.30319.225")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "https://secure.rpmware.com/api")]
	public class OrderTracking : ApiModelBase
	{
		private string notesField;

		private string shippingMethodField;

		private string trackingNumberField;

		/// <remarks />
		public string Notes
		{
			get { return notesField; }
			set { notesField = value; }
		}

		/// <remarks />
		public string ShippingMethod
		{
			get { return shippingMethodField; }
			set { shippingMethodField = value; }
		}

		/// <remarks />
		public string TrackingNumber
		{
			get { return trackingNumberField; }
			set { trackingNumberField = value; }
		}
	}

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	public delegate void AddHistoryCompletedEventHandler(object sender, AddHistoryCompletedEventArgs e);

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class AddHistoryCompletedEventArgs : AsyncCompletedEventArgs
	{
		private readonly object[] results;

		internal AddHistoryCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}

		/// <remarks />
		public Result Result
		{
			get
			{
				RaiseExceptionIfNecessary();
				return ((Result) (results[0]));
			}
		}
	}

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	public delegate void AddLineItemCompletedEventHandler(object sender, AddLineItemCompletedEventArgs e);

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class AddLineItemCompletedEventArgs : AsyncCompletedEventArgs
	{
		private readonly object[] results;

		internal AddLineItemCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}

		/// <remarks />
		public Result Result
		{
			get
			{
				RaiseExceptionIfNecessary();
				return ((Result) (results[0]));
			}
		}
	}

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	public delegate void AddTrackingNumberCompletedEventHandler(object sender, AddTrackingNumberCompletedEventArgs e);

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class AddTrackingNumberCompletedEventArgs : AsyncCompletedEventArgs
	{
		private readonly object[] results;

		internal AddTrackingNumberCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}

		/// <remarks />
		public Result Result
		{
			get
			{
				RaiseExceptionIfNecessary();
				return ((Result) (results[0]));
			}
		}
	}

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	public delegate void GetOrderCompletedEventHandler(object sender, GetOrderCompletedEventArgs e);

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class GetOrderCompletedEventArgs : AsyncCompletedEventArgs
	{
		private readonly object[] results;

		internal GetOrderCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}

		/// <remarks />
		public Result Result
		{
			get
			{
				RaiseExceptionIfNecessary();
				return ((Result) (results[0]));
			}
		}
	}

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	public delegate void GetOrderIdsSinceLastOrderIdCompletedEventHandler(object sender, GetOrderIdsSinceLastOrderIdCompletedEventArgs e);

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class GetOrderIdsSinceLastOrderIdCompletedEventArgs : AsyncCompletedEventArgs
	{
		private readonly object[] results;

		internal GetOrderIdsSinceLastOrderIdCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}

		/// <remarks />
		public Result Result
		{
			get
			{
				RaiseExceptionIfNecessary();
				return ((Result) (results[0]));
			}
		}
	}

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	public delegate void GetOrdersCompletedEventHandler(object sender, GetOrdersCompletedEventArgs e);

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class GetOrdersCompletedEventArgs : AsyncCompletedEventArgs
	{
		private readonly object[] results;

		internal GetOrdersCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}

		/// <remarks />
		public Result Result
		{
			get
			{
				RaiseExceptionIfNecessary();
				return ((Result) (results[0]));
			}
		}
	}

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	public delegate void GetOrdersByCustomerCompletedEventHandler(object sender, GetOrdersByCustomerCompletedEventArgs e);

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class GetOrdersByCustomerCompletedEventArgs : AsyncCompletedEventArgs
	{
		private readonly object[] results;

		internal GetOrdersByCustomerCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}

		/// <remarks />
		public Result Result
		{
			get
			{
				RaiseExceptionIfNecessary();
				return ((Result) (results[0]));
			}
		}
	}

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	public delegate void GetOrdersSinceLastOrderIdCompletedEventHandler(object sender, GetOrdersSinceLastOrderIdCompletedEventArgs e);

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class GetOrdersSinceLastOrderIdCompletedEventArgs : AsyncCompletedEventArgs
	{
		private readonly object[] results;

		internal GetOrdersSinceLastOrderIdCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}

		/// <remarks />
		public Result Result
		{
			get
			{
				RaiseExceptionIfNecessary();
				return ((Result) (results[0]));
			}
		}
	}
}

#pragma warning restore 1591