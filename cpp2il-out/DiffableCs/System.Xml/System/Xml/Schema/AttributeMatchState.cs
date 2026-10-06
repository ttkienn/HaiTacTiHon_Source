namespace System.Xml.Schema;

internal enum AttributeMatchState
{
	AttributeFound = 0,
	AnyIdAttributeFound = 1,
	UndeclaredElementAndAttribute = 2,
	UndeclaredAttribute = 3,
	AnyAttributeLax = 4,
	AnyAttributeSkip = 5,
	ProhibitedAnyAttribute = 6,
	ProhibitedAttribute = 7,
	AttributeNameMismatch = 8,
	ValidateAttributeInvalidCall = 9,
}

