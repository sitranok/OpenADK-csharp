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

/// <summary>A Sif3StudentScoreSet</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class Sif3StudentScoreSet : SifDataObject
{
	/// <summary>
	/// Creates an instance of a Sif3StudentScoreSet
	/// </summary>
	public Sif3StudentScoreSet() : base( Adk.SifVersion, AssessmentDTD.SIF3STUDENTSCORESET ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The GUID that uniquely identifies an instance of the object.</param>
	///<param name="scoreMetric">The metric or scale used to report the score.</param>
	///<param name="assessmentAdministrationRefId">The administration associated with this score set.</param>
	///<param name="studentPersonalRefId">The student associated with the response set.</param>
	///<param name="scoresSif3">A ScoresSif3</param>
	///
	public Sif3StudentScoreSet( string refId, AssessmentReportingMethod scoreMetric, string assessmentAdministrationRefId, string studentPersonalRefId, ScoresSif3 scoresSif3 ) : base( Adk.SifVersion, AssessmentDTD.SIF3STUDENTSCORESET )
	{
		this.RefId = refId;
		this.SetScoreMetric( scoreMetric );
		this.AssessmentAdministrationRefId = assessmentAdministrationRefId;
		this.StudentPersonalRefId = studentPersonalRefId;
		this.ScoresSif3 = scoresSif3;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Sif3StudentScoreSet( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.SIF3STUDENTSCORESET_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID that uniquely identifies an instance of the object."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3STUDENTSCORESET_REFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3STUDENTSCORESET_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>ScoreMetric</c> attribute.
	/// </summary>
	/// <value> The <c>ScoreMetric</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The metric or scale used to report the score."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string ScoreMetric
	{
		get
		{ 
			return GetFieldValue( AssessmentDTD.SIF3STUDENTSCORESET_SCOREMETRIC );
		}
		set
		{
			SetField( AssessmentDTD.SIF3STUDENTSCORESET_SCOREMETRIC, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>ScoreMetric</c> attribute.
	/// </summary>
	/// <param name="val">A AssessmentReportingMethod object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The metric or scale used to report the score."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetScoreMetric( AssessmentReportingMethod val )
	{
		SetField( AssessmentDTD.SIF3STUDENTSCORESET_SCOREMETRIC, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>AssessmentAdministrationRefId</c> attribute.
	/// </summary>
	/// <value> The <c>AssessmentAdministrationRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The administration associated with this score set."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssessmentAdministrationRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3STUDENTSCORESET_ASSESSMENTADMINISTRATIONREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3STUDENTSCORESET_ASSESSMENTADMINISTRATIONREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>StudentPersonalRefId</c> attribute.
	/// </summary>
	/// <value> The <c>StudentPersonalRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The student associated with the response set."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string StudentPersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3STUDENTSCORESET_STUDENTPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3STUDENTSCORESET_STUDENTPERSONALREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>AssessmentRegistrationRefId</c> attribute.
	/// </summary>
	/// <value> The <c>AssessmentRegistrationRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The registration associated with this score set."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssessmentRegistrationRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3STUDENTSCORESET_ASSESSMENTREGISTRATIONREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3STUDENTSCORESET_ASSESSMENTREGISTRATIONREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ScoresSif3&gt;</c> element.
	/// </summary>
	/// <value> A ScoresSif3 </value>
	/// <remarks>
	/// <para>To remove the <c>ScoresSif3</c>, set <c>ScoresSif3</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public ScoresSif3 ScoresSif3
	{
		get
		{
			return (ScoresSif3)GetChild( AssessmentDTD.SIF3STUDENTSCORESET_SCORESSIF3);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3STUDENTSCORESET_SCORESSIF3);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3STUDENTSCORESET_SCORESSIF3, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PassFailIndicator&gt;</c> element.
	/// </summary>
	/// <value> The <c>PassFailIndicator</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "If the score value also determines a pass/fail level, then this indicator will specify the value."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string PassFailIndicator
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3STUDENTSCORESET_PASSFAILINDICATOR ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3STUDENTSCORESET_PASSFAILINDICATOR, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;FeedbackItemsSif3StudentScoreSet&gt;</c> element.</summary>
	/// <param name="FeedbackItemSif3StudentScoreSet">A FeedbackItemSif3StudentScoreSet</param>
	///<remarks>
	/// <para>This form of <c>setFeedbackItemsSif3StudentScoreSet</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>FeedbackItemsSif3StudentScoreSet</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetFeedbackItemsSif3StudentScoreSet( FeedbackItemSif3StudentScoreSet FeedbackItemSif3StudentScoreSet ) {
		RemoveChild( AssessmentDTD.SIF3STUDENTSCORESET_FEEDBACKITEMSSIF3STUDENTSCORESET);
		AddChild( AssessmentDTD.SIF3STUDENTSCORESET_FEEDBACKITEMSSIF3STUDENTSCORESET, new FeedbackItemsSif3StudentScoreSet( FeedbackItemSif3StudentScoreSet ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FeedbackItemsSif3StudentScoreSet&gt;</c> element.
	/// </summary>
	/// <value> A FeedbackItemsSif3StudentScoreSet </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "This list will support providing feedback to the student from multiple sources."</para>
	/// <para>To remove the <c>FeedbackItemsSif3StudentScoreSet</c>, set <c>FeedbackItemsSif3StudentScoreSet</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public FeedbackItemsSif3StudentScoreSet FeedbackItemsSif3StudentScoreSet
	{
		get
		{
			return (FeedbackItemsSif3StudentScoreSet)GetChild( AssessmentDTD.SIF3STUDENTSCORESET_FEEDBACKITEMSSIF3STUDENTSCORESET);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3STUDENTSCORESET_FEEDBACKITEMSSIF3STUDENTSCORESET);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3STUDENTSCORESET_FEEDBACKITEMSSIF3STUDENTSCORESET, value );
			}
		}
	}

}}
