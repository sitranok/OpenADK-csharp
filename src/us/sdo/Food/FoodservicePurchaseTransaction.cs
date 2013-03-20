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

namespace OpenADK.Library.us.Food{

/// <summary>A FoodservicePurchaseTransaction</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class FoodservicePurchaseTransaction : SifDataObject
{
	/// <summary>
	/// Creates an instance of a FoodservicePurchaseTransaction
	/// </summary>
	public FoodservicePurchaseTransaction() : base( Adk.SifVersion, FoodDTD.FOODSERVICEPURCHASETRANSACTION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">GUID that identifies purchase transaction</param>
	///<param name="foodserviceTransactionRefId">GUID that identifies food service transaction in which this purchase was made</param>
	///<param name="purchaseQuantities">A PurchaseQuantities</param>
	///
	public FoodservicePurchaseTransaction( string refId, string foodserviceTransactionRefId, PurchaseQuantities purchaseQuantities ) : base( Adk.SifVersion, FoodDTD.FOODSERVICEPURCHASETRANSACTION )
	{
		this.RefId = refId;
		this.FoodserviceTransactionRefId = foodserviceTransactionRefId;
		this.PurchaseQuantities = purchaseQuantities;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected FoodservicePurchaseTransaction( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { FoodDTD.FOODSERVICEPURCHASETRANSACTION_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "GUID that identifies purchase transaction"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( FoodDTD.FOODSERVICEPURCHASETRANSACTION_REFID ) ;
		}
		set
		{
			SetFieldValue( FoodDTD.FOODSERVICEPURCHASETRANSACTION_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FoodserviceTransactionRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>FoodserviceTransactionRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "GUID that identifies food service transaction in which this purchase was made"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string FoodserviceTransactionRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( FoodDTD.FOODSERVICEPURCHASETRANSACTION_FOODSERVICETRANSACTIONREFID ) ;
		}
		set
		{
			SetFieldValue( FoodDTD.FOODSERVICEPURCHASETRANSACTION_FOODSERVICETRANSACTIONREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PurchaseQuantities&gt;</c> element.
	/// </summary>
	/// <value> A PurchaseQuantities </value>
	/// <remarks>
	/// <para>To remove the <c>PurchaseQuantities</c>, set <c>PurchaseQuantities</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public PurchaseQuantities PurchaseQuantities
	{
		get
		{
			return (PurchaseQuantities)GetChild( FoodDTD.FOODSERVICEPURCHASETRANSACTION_PURCHASEQUANTITIES);
		}
		set
		{
			RemoveChild( FoodDTD.FOODSERVICEPURCHASETRANSACTION_PURCHASEQUANTITIES);
			if( value != null)
			{
				AddChild( FoodDTD.FOODSERVICEPURCHASETRANSACTION_PURCHASEQUANTITIES, value );
			}
		}
	}

}}
