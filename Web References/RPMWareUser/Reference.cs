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

namespace RPMWare.Api.Client.RPMWareUser
{
	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[WebServiceBinding(Name = "UserSoap", Namespace = "https://secure.rpmware.com/api")]
	[XmlInclude(typeof (ApiToken))]
	public class User : SoapHttpClientProtocol
	{
		private SendOrPostCallback AmILoggedInOperationCompleted;

		private SendOrPostCallback LoginOperationCompleted;

		private SendOrPostCallback LogoutOperationCompleted;

		private bool useDefaultCredentialsSetExplicitly;

		/// <remarks />
		public User()
		{
			Url = Settings.Default.RPMWare_Api_Client_RPMWareUser_User;
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
		public event AmILoggedInCompletedEventHandler AmILoggedInCompleted;

		/// <remarks />
		public event LoginCompletedEventHandler LoginCompleted;

		/// <remarks />
		public event LogoutCompletedEventHandler LogoutCompleted;

		/// <remarks />
		[SoapDocumentMethod("https://secure.rpmware.com/api/AmILoggedIn", RequestNamespace = "https://secure.rpmware.com/api", ResponseNamespace = "https://secure.rpmware.com/api",
			Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public Result AmILoggedIn(string apiToken)
		{
			object[] results = Invoke("AmILoggedIn", new object[] {apiToken});
			return ((Result) (results[0]));
		}

		/// <remarks />
		public void AmILoggedInAsync(string apiToken)
		{
			AmILoggedInAsync(apiToken, null);
		}

		/// <remarks />
		public void AmILoggedInAsync(string apiToken, object userState)
		{
			if ((AmILoggedInOperationCompleted == null))
			{
				AmILoggedInOperationCompleted = new SendOrPostCallback(OnAmILoggedInOperationCompleted);
			}
			InvokeAsync("AmILoggedIn", new object[] {apiToken}, AmILoggedInOperationCompleted, userState);
		}

		private void OnAmILoggedInOperationCompleted(object arg)
		{
			if ((AmILoggedInCompleted != null))
			{
				var invokeArgs = ((InvokeCompletedEventArgs) (arg));
				AmILoggedInCompleted(this, new AmILoggedInCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}

		/// <remarks />
		[SoapDocumentMethod("https://secure.rpmware.com/api/Login", RequestNamespace = "https://secure.rpmware.com/api", ResponseNamespace = "https://secure.rpmware.com/api",
			Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public Result Login(string email, string password)
		{
			object[] results = Invoke("Login", new object[] {email, password});
			return ((Result) (results[0]));
		}

		/// <remarks />
		public void LoginAsync(string email, string password)
		{
			LoginAsync(email, password, null);
		}

		/// <remarks />
		public void LoginAsync(string email, string password, object userState)
		{
			if ((LoginOperationCompleted == null))
			{
				LoginOperationCompleted = new SendOrPostCallback(OnLoginOperationCompleted);
			}
			InvokeAsync("Login", new object[] {email, password}, LoginOperationCompleted, userState);
		}

		private void OnLoginOperationCompleted(object arg)
		{
			if ((LoginCompleted != null))
			{
				var invokeArgs = ((InvokeCompletedEventArgs) (arg));
				LoginCompleted(this, new LoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}

		/// <remarks />
		[SoapDocumentMethod("https://secure.rpmware.com/api/Logout", RequestNamespace = "https://secure.rpmware.com/api", ResponseNamespace = "https://secure.rpmware.com/api",
			Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public Result Logout(string apiToken)
		{
			object[] results = Invoke("Logout", new object[] {apiToken});
			return ((Result) (results[0]));
		}

		/// <remarks />
		public void LogoutAsync(string apiToken)
		{
			LogoutAsync(apiToken, null);
		}

		/// <remarks />
		public void LogoutAsync(string apiToken, object userState)
		{
			if ((LogoutOperationCompleted == null))
			{
				LogoutOperationCompleted = new SendOrPostCallback(OnLogoutOperationCompleted);
			}
			InvokeAsync("Logout", new object[] {apiToken}, LogoutOperationCompleted, userState);
		}

		private void OnLogoutOperationCompleted(object arg)
		{
			if ((LogoutCompleted != null))
			{
				var invokeArgs = ((InvokeCompletedEventArgs) (arg));
				LogoutCompleted(this, new LogoutCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
	[GeneratedCode("System.Xml", "4.0.30319.225")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "https://secure.rpmware.com/api")]
	public class ApiToken
	{
		private DateTime tokenExpirationField;
		private string tokenField;

		/// <remarks />
		public string Token
		{
			get { return tokenField; }
			set { tokenField = value; }
		}

		/// <remarks />
		public DateTime TokenExpiration
		{
			get { return tokenExpirationField; }
			set { tokenExpirationField = value; }
		}
	}

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	public delegate void AmILoggedInCompletedEventHandler(object sender, AmILoggedInCompletedEventArgs e);

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class AmILoggedInCompletedEventArgs : AsyncCompletedEventArgs
	{
		private readonly object[] results;

		internal AmILoggedInCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
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
	public delegate void LoginCompletedEventHandler(object sender, LoginCompletedEventArgs e);

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class LoginCompletedEventArgs : AsyncCompletedEventArgs
	{
		private readonly object[] results;

		internal LoginCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
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
	public delegate void LogoutCompletedEventHandler(object sender, LogoutCompletedEventArgs e);

	/// <remarks />
	[GeneratedCode("System.Web.Services", "4.0.30319.1")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class LogoutCompletedEventArgs : AsyncCompletedEventArgs
	{
		private readonly object[] results;

		internal LogoutCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
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