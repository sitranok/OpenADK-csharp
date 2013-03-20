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

/// <summary>This object communicates a financial transaction. A transaction can be for the daily food sales revenue account.  SIF_Events are reported.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class FinancialTransaction : SifDataObject
{
	/// <summary>
	/// Creates an instance of a FinancialTransaction
	/// </summary>
	public FinancialTransaction() : base( Adk.SifVersion, HrfinDTD.FINANCIALTRANSACTION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">GUID that identifies this financial transaction.</param>
	///<param name="transactionDate">Transaction date.</param>
	///<param name="transactionTime">Transaction time.</param>
	///<param name="amounts">Dollar amount of the transaction.</param>
	///
	public FinancialTransaction( string refId, DateTime? transactionDate, DateTime? transactionTime, FTAmounts amounts ) : base( Adk.SifVersion, HrfinDTD.FINANCIALTRANSACTION )
	{
		this.RefId = refId;
		this.TransactionDate = transactionDate;
		this.TransactionTime = transactionTime;
		this.Amounts = amounts;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected FinancialTransaction( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { HrfinDTD.FINANCIALTRANSACTION_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "GUID that identifies this financial transaction."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.FINANCIALTRANSACTION_REFID ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.FINANCIALTRANSACTION_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TransactionDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>TransactionDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Transaction date."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public DateTime? TransactionDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( HrfinDTD.FINANCIALTRANSACTION_TRANSACTIONDATE ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.FINANCIALTRANSACTION_TRANSACTIONDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TransactionTime&gt;</c> element.
	/// </summary>
	/// <value> The <c>TransactionTime</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Transaction time."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public DateTime? TransactionTime
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( HrfinDTD.FINANCIALTRANSACTION_TRANSACTIONTIME ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.FINANCIALTRANSACTION_TRANSACTIONTIME, new SifTime( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Amounts&gt;</c> element.
	/// </summary>
	/// <value> A FTAmounts </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Dollar amount of the transaction."</para>
	/// <para>To remove the <c>FTAmounts</c>, set <c>Amounts</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public FTAmounts Amounts
	{
		get
		{
			return (FTAmounts)GetChild( HrfinDTD.FINANCIALTRANSACTION_AMOUNTS);
		}
		set
		{
			RemoveChild( HrfinDTD.FINANCIALTRANSACTION_AMOUNTS);
			if( value != null)
			{
				AddChild( HrfinDTD.FINANCIALTRANSACTION_AMOUNTS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;Program&gt;</c> element.</summary>
	/// <param name="Type">The type of the program. Type identifies the list of values.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;Program&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setProgram</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Program</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetProgram( FinancialProgram Type, string Value ) {
		RemoveChild( HrfinDTD.FINANCIALTRANSACTION_PROGRAM);
		AddChild( HrfinDTD.FINANCIALTRANSACTION_PROGRAM, new Program( Type, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Program&gt;</c> element.
	/// </summary>
	/// <value> A Program </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "See 5.1.23 Program."</para>
	/// <para>To remove the <c>Program</c>, set <c>Program</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public Program Program
	{
		get
		{
			return (Program)GetChild( HrfinDTD.FINANCIALTRANSACTION_PROGRAM);
		}
		set
		{
			RemoveChild( HrfinDTD.FINANCIALTRANSACTION_PROGRAM);
			if( value != null)
			{
				AddChild( HrfinDTD.FINANCIALTRANSACTION_PROGRAM, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Description."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.FINANCIALTRANSACTION_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.FINANCIALTRANSACTION_DESCRIPTION, new SifString( value ), value );
		}
	}

}}
