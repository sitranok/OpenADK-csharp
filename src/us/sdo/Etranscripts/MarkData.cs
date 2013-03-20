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
using OpenADK.Library.us.Gradebook;
using OpenADK.Library.us.Student;

namespace OpenADK.Library.us.Etranscripts{

/// <summary>A MarkData</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class MarkData : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a MarkData
	/// </summary>
	public MarkData() : base ( EtranscriptsDTD.MARKDATA ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="markValueInfoDataRefId">Reference to marking system at school of record.</param>
	///
	public MarkData( string markValueInfoDataRefId ) : base( EtranscriptsDTD.MARKDATA )
	{
		this.MarkValueInfoDataRefId = markValueInfoDataRefId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected MarkData( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { EtranscriptsDTD.MARKDATA_MARKVALUEINFODATAREFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>MarkValueInfoDataRefId</c> attribute.
	/// </summary>
	/// <value> The <c>MarkValueInfoDataRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Reference to marking system at school of record."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string MarkValueInfoDataRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( EtranscriptsDTD.MARKDATA_MARKVALUEINFODATAREFID ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.MARKDATA_MARKVALUEINFODATAREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Percentage&gt;</c> element.
	/// </summary>
	/// <value> The <c>Percentage</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The percent score for this mark (0.00 - 100.00)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public decimal? Percentage
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( EtranscriptsDTD.MARKDATA_PERCENTAGE ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.MARKDATA_PERCENTAGE, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Numeric&gt;</c> element.
	/// </summary>
	/// <value> The <c>Numeric</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The raw numeric score for this mark."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public int? Numeric
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( EtranscriptsDTD.MARKDATA_NUMERIC ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.MARKDATA_NUMERIC, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;NumericAsDecimal&gt;</c> element.
	/// </summary>
	/// <value> The <c>NumericAsDecimal</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The raw numeric score for this mark. This element allows for a numeric mark (score or grade) in decimal format."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public decimal? NumericAsDecimal
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( EtranscriptsDTD.MARKDATA_NUMERICASDECIMAL ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.MARKDATA_NUMERICASDECIMAL, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Letter&gt;</c> element.
	/// </summary>
	/// <value> The <c>Letter</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The letter grade for this mark."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Letter
	{
		get
		{
			return (string) GetSifSimpleFieldValue( EtranscriptsDTD.MARKDATA_LETTER ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.MARKDATA_LETTER, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Narrative&gt;</c> element.
	/// </summary>
	/// <value> The <c>Narrative</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The free form text narrative for this mark."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Narrative
	{
		get
		{
			return (string) GetSifSimpleFieldValue( EtranscriptsDTD.MARKDATA_NARRATIVE ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.MARKDATA_NARRATIVE, new SifString( value ), value );
		}
	}

}}
