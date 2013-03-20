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
using OpenADK.Library.au.Common;

namespace OpenADK.Library.au.Sif3assessment{

/// <summary>A FeedbackItemList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class FeedbackItemList : SifList<FeedbackItem>
{
	/// <summary>
	/// Creates an instance of a FeedbackItemList
	/// </summary>
	public FeedbackItemList() : base ( Sif3assessmentDTD.FEEDBACKITEMLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="feedbackItem">A FeedbackItem</param>
	///
	public FeedbackItemList( FeedbackItem feedbackItem ) : base( Sif3assessmentDTD.FEEDBACKITEMLIST )
	{
		this.SafeAddChild( Sif3assessmentDTD.FEEDBACKITEMLIST_FEEDBACKITEM, feedbackItem );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected FeedbackItemList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { Sif3assessmentDTD.FEEDBACKITEMLIST_FEEDBACKITEM }; }
	}

}}
