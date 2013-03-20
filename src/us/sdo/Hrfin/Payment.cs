// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;
using OpenADK.Library.us.Common;

namespace OpenADK.Library.us.Hrfin{

/// <summary>This object complements the Billing object, and contains information about the payment of a billing object.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class Payment : SifDataObject
{
	/// <summary>
	/// Creates an instance of a Payment
	/// </summary>
	public Payment() : base( Adk.SifVersion, HrfinDTD.PAYMENT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">GUID for this transaction. The application that owns this object is responsible for generating this unique ID.</param>
	///<param name="entityId">ID of the entity related to this billing activity (e.g. student ID, employee ID, organization, etc.)</param>
	///<param name="billingRefId">A pointer back to the Billing object.</param>
	///<param name="receivedDate">Date payment was received.</param>
	///<param name="transactionDescription">Description of the transaction.</param>
	///<param name="receivedAmount">Amount received.</param>
	///<param name="receivedTransactionId">Memo transaction ID from other vendor software.</param>
	///
	public Payment( string refId, string entityId, string billingRefId, DateTime? receivedDate, string transactionDescription, MonetaryAmount receivedAmount, string receivedTransactionId ) : base( Adk.SifVersion, HrfinDTD.PAYMENT )
	{
		this.RefId = refId;
		this.EntityId = entityId;
		this.BillingRefId = billingRefId;
		this.ReceivedDate = receivedDate;
		this.TransactionDescription = transactionDescription;
		this.ReceivedAmount = receivedAmount;
		this.ReceivedTransactionId = receivedTransactionId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Payment( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { HrfinDTD.PAYMENT_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "GUID for this transaction. The application that owns this object is responsible for generating this unique ID."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.PAYMENT_REFID ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.PAYMENT_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EntityId&gt;</c> element.
	/// </summary>
	/// <value> The <c>EntityId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "ID of the entity related to this billing activity (e.g. student ID, employee ID, organization, etc.)"</para>
	/// <para>Version: 1.5r1</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string EntityId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.PAYMENT_ENTITYID ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.PAYMENT_ENTITYID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>BillingRefId</c> attribute.
	/// </summary>
	/// <value> The <c>BillingRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "A pointer back to the Billing object."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string BillingRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.PAYMENT_BILLINGREFID ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.PAYMENT_BILLINGREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ReceivedDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>ReceivedDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date payment was received."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public DateTime? ReceivedDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( HrfinDTD.PAYMENT_RECEIVEDDATE ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.PAYMENT_RECEIVEDDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TransactionDescription&gt;</c> element.
	/// </summary>
	/// <value> The <c>TransactionDescription</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Description of the transaction."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string TransactionDescription
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.PAYMENT_TRANSACTIONDESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.PAYMENT_TRANSACTIONDESCRIPTION, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;ReceivedAmount&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;MonetaryAmount&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setReceivedAmount</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ReceivedAmount</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetReceivedAmount( decimal? Value ) {
		RemoveChild( HrfinDTD.PAYMENT_RECEIVEDAMOUNT);
		AddChild( HrfinDTD.PAYMENT_RECEIVEDAMOUNT, new MonetaryAmount( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ReceivedAmount&gt;</c> element.
	/// </summary>
	/// <value> A MonetaryAmount </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Amount received."</para>
	/// <para>To remove the <c>MonetaryAmount</c>, set <c>ReceivedAmount</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public MonetaryAmount ReceivedAmount
	{
		get
		{
			return (MonetaryAmount)GetChild( HrfinDTD.PAYMENT_RECEIVEDAMOUNT);
		}
		set
		{
			RemoveChild( HrfinDTD.PAYMENT_RECEIVEDAMOUNT);
			if( value != null)
			{
				AddChild( HrfinDTD.PAYMENT_RECEIVEDAMOUNT, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ReceivedTransactionId&gt;</c> element.
	/// </summary>
	/// <value> The <c>ReceivedTransactionId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Memo transaction ID from other vendor software."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string ReceivedTransactionId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.PAYMENT_RECEIVEDTRANSACTIONID ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.PAYMENT_RECEIVEDTRANSACTIONID, new SifString( value ), value );
		}
	}

}}
