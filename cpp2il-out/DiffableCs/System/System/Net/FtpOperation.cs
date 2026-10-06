namespace System.Net;

internal enum FtpOperation
{
	DownloadFile = 0,
	ListDirectory = 1,
	ListDirectoryDetails = 2,
	UploadFile = 3,
	UploadFileUnique = 4,
	AppendFile = 5,
	DeleteFile = 6,
	GetDateTimestamp = 7,
	GetFileSize = 8,
	Rename = 9,
	MakeDirectory = 10,
	RemoveDirectory = 11,
	PrintWorkingDirectory = 12,
	Other = 13,
}

