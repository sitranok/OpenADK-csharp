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

namespace OpenADK.Library.us.Assessment{

/// <summary>This object provides specific information about each assessment item. This information includes an
	///             analysis, psychometric measures, reliability and validity information. This item-level information assists
	///             in interpreting assessment scores as well as aide in improving teaching and learning.
	///         </summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class ItemCharacteristics : SifDataObject
{
	/// <summary>
	/// Creates an instance of an ItemCharacteristics
	/// </summary>
	public ItemCharacteristics() : base( Adk.SifVersion, AssessmentDTD.ITEMCHARACTERISTICS ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ItemCharacteristics( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.ITEMCHARACTERISTICS_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ITEMCHARACTERISTICS_REFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ITEMCHARACTERISTICS_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>AssessmentItemRefId</c> attribute.
	/// </summary>
	/// <value> The <c>AssessmentItemRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "This RefId points to the assessment item of which the characteristics are a part."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string AssessmentItemRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ITEMCHARACTERISTICS_ASSESSMENTITEMREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ITEMCHARACTERISTICS_ASSESSMENTITEMREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>AssessmentFormRefId</c> attribute.
	/// </summary>
	/// <value> The <c>AssessmentFormRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "This RefId points to the assessment form of which the item is a part."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string AssessmentFormRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ITEMCHARACTERISTICS_ASSESSMENTFORMREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ITEMCHARACTERISTICS_ASSESSMENTFORMREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PercentCorrect&gt;</c> element.
	/// </summary>
	/// <value> The <c>PercentCorrect</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Number of correct answers in sample."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.5</para>
	/// </remarks>
	public decimal? PercentCorrect
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( AssessmentDTD.ITEMCHARACTERISTICS_PERCENTCORRECT ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ITEMCHARACTERISTICS_PERCENTCORRECT, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SampleSize&gt;</c> element.
	/// </summary>
	/// <value> The <c>SampleSize</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Number of total Item exposures."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.5</para>
	/// </remarks>
	public int? SampleSize
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( AssessmentDTD.ITEMCHARACTERISTICS_SAMPLESIZE ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ITEMCHARACTERISTICS_SAMPLESIZE, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Descriptive&gt;</c> element.
	/// </summary>
	/// <value> A Descriptive </value>
	/// <remarks>
	/// <para>To remove the <c>Descriptive</c>, set <c>Descriptive</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public Descriptive Descriptive
	{
		get
		{
			return (Descriptive)GetChild( AssessmentDTD.ITEMCHARACTERISTICS_DESCRIPTIVE);
		}
		set
		{
			RemoveChild( AssessmentDTD.ITEMCHARACTERISTICS_DESCRIPTIVE);
			if( value != null)
			{
				AddChild( AssessmentDTD.ITEMCHARACTERISTICS_DESCRIPTIVE, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DifferentialItemAnalysis&gt;</c> element.
	/// </summary>
	/// <value> A DifferentialItemAnalysis </value>
	/// <remarks>
	/// <para>To remove the <c>DifferentialItemAnalysis</c>, set <c>DifferentialItemAnalysis</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public DifferentialItemAnalysis DifferentialItemAnalysis
	{
		get
		{
			return (DifferentialItemAnalysis)GetChild( AssessmentDTD.ITEMCHARACTERISTICS_DIFFERENTIALITEMANALYSIS);
		}
		set
		{
			RemoveChild( AssessmentDTD.ITEMCHARACTERISTICS_DIFFERENTIALITEMANALYSIS);
			if( value != null)
			{
				AddChild( AssessmentDTD.ITEMCHARACTERISTICS_DIFFERENTIALITEMANALYSIS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SampleDescription&gt;</c> element.
	/// </summary>
	/// <value> The <c>SampleDescription</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The description of the Sample the statistics are based on. May be District name, State or National
	///                 sample.
	///             "</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.5</para>
	/// </remarks>
	public string SampleDescription
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ITEMCHARACTERISTICS_SAMPLEDESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ITEMCHARACTERISTICS_SAMPLEDESCRIPTION, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;Measurements&gt;</c> element.</summary>
	/// <param name="Measurement">Container for series of item statistics.</param>
	///<remarks>
	/// <para>This form of <c>setMeasurements</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Measurements</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.5</para>
	/// </remarks>
	public void SetMeasurements( Measurement Measurement ) {
		RemoveChild( AssessmentDTD.ITEMCHARACTERISTICS_MEASUREMENTS);
		AddChild( AssessmentDTD.ITEMCHARACTERISTICS_MEASUREMENTS, new Measurements( Measurement ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Measurements&gt;</c> element.
	/// </summary>
	/// <value> A Measurements </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "A repeating group of psychometric measures."</para>
	/// <para>To remove the <c>Measurements</c>, set <c>Measurements</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.5</para>
	/// </remarks>
	public Measurements Measurements
	{
		get
		{
			return (Measurements)GetChild( AssessmentDTD.ITEMCHARACTERISTICS_MEASUREMENTS);
		}
		set
		{
			RemoveChild( AssessmentDTD.ITEMCHARACTERISTICS_MEASUREMENTS);
			if( value != null)
			{
				AddChild( AssessmentDTD.ITEMCHARACTERISTICS_MEASUREMENTS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ResponseChoicePattern&gt;</c> element.
	/// </summary>
	/// <value> A ResponseChoicePattern </value>
	/// <remarks>
	/// <para>To remove the <c>ResponseChoicePattern</c>, set <c>ResponseChoicePattern</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public ResponseChoicePattern ResponseChoicePattern
	{
		get
		{
			return (ResponseChoicePattern)GetChild( AssessmentDTD.ITEMCHARACTERISTICS_RESPONSECHOICEPATTERN);
		}
		set
		{
			RemoveChild( AssessmentDTD.ITEMCHARACTERISTICS_RESPONSECHOICEPATTERN);
			if( value != null)
			{
				AddChild( AssessmentDTD.ITEMCHARACTERISTICS_RESPONSECHOICEPATTERN, value );
			}
		}
	}

}}
