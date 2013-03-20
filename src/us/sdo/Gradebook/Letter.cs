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

namespace OpenADK.Library.us.Gradebook{

/// <summary>A Letter</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class Letter : SifList<ValidMark>
{
	/// <summary>
	/// Creates an instance of a Letter
	/// </summary>
	public Letter() : base ( GradebookDTD.LETTER ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="isAccepted">Indicates whether a letter Mark is accepted and is used in Change events to unambiguously signal whether support for the Mark has changed, especially ended.</param>
	///
	public Letter( bool? isAccepted ) : base( GradebookDTD.LETTER )
	{
		this.IsAccepted = isAccepted;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Letter( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { GradebookDTD.LETTER_ISACCEPTED }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>IsAccepted</c> attribute.
	/// </summary>
	/// <value> The <c>IsAccepted</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Indicates whether a letter Mark is accepted and is used in Change events to unambiguously signal whether support for the Mark has changed, especially ended."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public bool? IsAccepted
	{
		get
		{
			return (bool?) GetSifSimpleFieldValue( GradebookDTD.LETTER_ISACCEPTED ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.LETTER_ISACCEPTED, new SifBoolean( value ), value );
		}
	}

	/// <summary>Adds a new <c>&lt;ValidMark&gt;</c> child element.</summary>
	/// <param name="val">A ValidMark object</param>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddValidMark( ValidMark val ) { 
		AddChild( GradebookDTD.LETTER_VALIDMARK, val );
	}

	///<summary>Adds the value of the <c>&lt;ValidMark&gt;</c> element.</summary>
	/// <param name="Code">String representing the actual Mark that would appear on the report card (e.g., "A+", "I", "100").</param>
	///<remarks>
	/// <para>This form of <c>setValidMark</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddValidMark</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddValidMark( string Code ) {
		AddChild( GradebookDTD.LETTER_VALIDMARK, new ValidMark( Code ) );
	}

	/// <summary>
	/// Removes a <see cref="ValidMark"/> object instance. More than one instance can be defined for this object because it is a repeatable field element.
	/// </summary>
	/// <param name="Code">Identifies the ValidMark object to remove by its Code value</param>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void RemoveValidMark( string Code ) { 
		RemoveChild( GradebookDTD.LETTER_VALIDMARK, new String[] { Code.ToString() } );
	}

	/// <summary>
	/// Gets a <see cref="ValidMark"/> object instance. More than one instance can be defined for this object because it is a repeatable field element.
	/// </summary>
	/// <param name="Code">Identifies the ValidMark object to return by its "Code" attribute value</param>
	/// <returns>A ValidMark object</returns>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public ValidMark GetValidMark( string Code ) { 
		return (ValidMark)GetChild( GradebookDTD.LETTER_VALIDMARK, new string[] { Code.ToString() } );
	}

	/// <summary>
	/// Gets all ValidMark object instances. More than once instance can be defined for this object because it is a repeatable field element.
	/// </summary>
	/// <returns>An array of ValidMark objects</returns>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public ValidMark[] GetValidMarks()
	{
		return GetChildren<ValidMark>().ToArray();
	}

	/// <summary>
	/// Sets all ValidMark object instances. All existing 
	/// <c>ValidMark</c> instances 
	/// are removed and replaced with this list. Calling this method with the 
	/// parameter value set to null removes all <c>ValidMarks</c>.
	/// </summary>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetValidMarks( ValidMark[] items)
	{
		SetChildren( GradebookDTD.LETTER_VALIDMARK, items );
	}

}}
