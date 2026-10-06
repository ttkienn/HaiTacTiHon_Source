namespace System.Net;

internal enum CookieToken
{
	Nothing = 0,
	NameValuePair = 1,
	Attribute = 2,
	EndToken = 3,
	EndCookie = 4,
	End = 5,
	Equals = 6,
	Comment = 7,
	CommentUrl = 8,
	CookieName = 9,
	Discard = 10,
	Domain = 11,
	Expires = 12,
	MaxAge = 13,
	Path = 14,
	Port = 15,
	Secure = 16,
	HttpOnly = 17,
	Unknown = 18,
	Version = 19,
}

