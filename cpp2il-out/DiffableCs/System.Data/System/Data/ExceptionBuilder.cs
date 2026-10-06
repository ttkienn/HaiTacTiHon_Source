namespace System.Data;

internal static class ExceptionBuilder
{

	internal static Exception _Argument(string error) { }

	internal static Exception _Argument(string error, Exception innerException) { }

	private static Exception _ArgumentNull(string paramName, string msg) { }

	internal static Exception _ArgumentOutOfRange(string paramName, string msg) { }

	private static Exception _Constraint(string error) { }

	private static Exception _Data(string error) { }

	private static Exception _DeletedRowInaccessible(string error) { }

	private static Exception _DuplicateName(string error) { }

	private static Exception _IndexOutOfRange(string error) { }

	private static Exception _InRowChangingEvent(string error) { }

	private static Exception _InvalidConstraint(string error) { }

	private static Exception _InvalidEnumArgumentException(string error) { }

	private static Exception _InvalidEnumArgumentException(T value) { }

	private static Exception _InvalidOperation(string error) { }

	private static Exception _NoNullAllowed(string error) { }

	private static Exception _ReadOnly(string error) { }

	private static Exception _RowNotInTable(string error) { }

	private static Exception _VersionNotFound(string error) { }

	public static Exception AddExternalObject() { }

	public static Exception AddNewNotAllowNull() { }

	public static Exception AddPrimaryKeyConstraint() { }

	public static Exception AggregateException(AggregateType aggregateType, Type type) { }

	public static Exception ArgumentNull(string paramName) { }

	public static Exception ArgumentOutOfRange(string paramName) { }

	public static Exception AttributeValues(string name, string value1, string value2) { }

	public static Exception AutoIncrementAndDefaultValue() { }

	public static Exception AutoIncrementAndExpression() { }

	public static Exception AutoIncrementCannotSetIfHasData(string typeName) { }

	public static Exception AutoIncrementSeed() { }

	public static Exception BadObjectPropertyAccess(string error) { }

	public static Exception BeginEditInRowChanging() { }

	public static Exception CancelEditInRowChanging() { }

	public static Exception CannotAddColumn1(string column) { }

	public static Exception CannotAddColumn2(string column) { }

	public static Exception CannotAddColumn3() { }

	public static Exception CannotAddColumn4(string column) { }

	public static Exception CannotAddDuplicate(string column) { }

	public static Exception CannotAddDuplicate2(string table) { }

	public static Exception CannotAddDuplicate3(string table) { }

	public static Exception CannotChangeCaseLocale(Exception innerException) { }

	public static Exception CannotChangeCaseLocale() { }

	public static Exception CannotChangeNamespace(string columnName) { }

	public static Exception CanNotClear() { }

	public static Exception CannotConvert(string name, string type) { }

	public static Exception CanNotDelete() { }

	public static Exception CanNotDeserializeObjectType() { }

	public static Exception CannotInstantiateAbstract(string name) { }

	public static Exception CanNotRemoteDataTable() { }

	public static Exception CannotRemoveChildKey(string relation) { }

	public static Exception CannotRemoveColumn() { }

	public static Exception CannotRemoveConstraint(string constraint, string table) { }

	public static Exception CannotRemoveExpression(string column, string expression) { }

	public static Exception CannotRemovePrimaryKey() { }

	public static Exception CanNotSerializeDataTableHierarchy() { }

	public static Exception CanNotSerializeDataTableWithEmptyName() { }

	public static Exception CannotSetDateTimeModeForNonDateTimeColumns() { }

	public static Exception CannotSetMaxLength(DataColumn column, int value) { }

	public static Exception CannotSetMaxLength2(DataColumn column) { }

	public static Exception CanNotSetRemotingFormat() { }

	public static Exception CannotSetSimpleContent(string columnName, Type type) { }

	public static Exception CannotSetSimpleContentType(string columnName, Type type) { }

	public static Exception CannotSetToNull(DataColumn column) { }

	public static Exception CanNotUse() { }

	public static Exception CantAddConstraintToMultipleNestedTable(string tableName) { }

	public static Exception CantChangeDataType() { }

	public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue) { }

	public static Exception CaseInsensitiveNameConflict(string name) { }

	public static Exception CaseLocaleMismatch() { }

	public static Exception ChildTableMismatch() { }

	public static Exception CircularComplexType(string name) { }

	public static Exception ColumnNameRequired() { }

	public static Exception ColumnNotInAnyTable() { }

	public static Exception ColumnNotInTheTable(string column, string table) { }

	public static Exception ColumnOutOfRange(string column) { }

	public static Exception ColumnOutOfRange(int index) { }

	public static Exception ColumnsTypeMismatch() { }

	public static Exception ColumnTypeConflict(string name) { }

	public static Exception ColumnTypeNotSupported() { }

	public static Exception ConstraintAddFailed(DataTable table) { }

	public static Exception ConstraintForeignTable() { }

	public static Exception ConstraintOutOfRange(int index) { }

	public static Exception ConstraintParentValues() { }

	public static Exception ConstraintRemoveFailed() { }

	public static Exception ConstraintViolation(DataColumn[] columns, Object[] values) { }

	public static Exception ConstraintViolation(string constraint) { }

	public static Exception ConvertFailed(Type type1, Type type2) { }

	public static Exception CreateChildView() { }

	public static Exception DatasetConflictingName(string table) { }

	public static Exception DataSetUnsupportedSchema(string ns) { }

	public static Exception DataTableInferenceNotSupported() { }

	public static Exception DatatypeNotDefined() { }

	public static Exception DefaultValueAndAutoIncrement() { }

	public static Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	public static Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	public static Exception DeletedRowInaccessible() { }

	public static Exception DeleteInRowDeleting() { }

	public static Exception DiffgramMissingSQL() { }

	public static Exception DiffgramMissingTable(string name) { }

	public static Exception DuplicateConstraint(string constraint) { }

	public static Exception DuplicateConstraintName(string constraint) { }

	public static Exception DuplicateConstraintRead(string str) { }

	public static Exception DuplicateDeclaration(string name) { }

	public static Exception DuplicateRelation(string relation) { }

	public static Exception DuplicateTableName(string table) { }

	public static Exception DuplicateTableName2(string table, string ns) { }

	public static Exception EditInRowChanging() { }

	public static Exception ElementTypeNotFound(string name) { }

	public static Exception EndEditInRowChanging() { }

	public static Exception EnforceConstraint() { }

	public static Exception EnumeratorModified() { }

	public static Exception ExpressionAndConstraint(DataColumn column, Constraint constraint) { }

	public static Exception ExpressionAndReadOnly() { }

	public static Exception ExpressionAndUnique() { }

	public static Exception ExpressionCircular() { }

	public static Exception ExpressionInConstraint(DataColumn column) { }

	public static Exception FailedCascadeDelete(string constraint) { }

	public static Exception FailedCascadeUpdate(string constraint) { }

	public static Exception FailedClearParentTable(string table, string constraint, string childTable) { }

	public static Exception ForeignKeyViolation(string constraint, Object[] keys) { }

	public static Exception ForeignRelation() { }

	public static Exception FoundEntity() { }

	public static Exception GetElementIndex(int index) { }

	public static Exception GetParentRowTableMismatch(string t1, string t2) { }

	public static Exception HasToBeStringType(DataColumn column) { }

	public static Exception IComparableNotImplemented(string typeName) { }

	public static Exception IndexKeyLength(int length, int keyLength) { }

	public static Exception InsertExternalObject() { }

	internal static Exception InternalRBTreeError(RBTreeError internalError) { }

	public static Exception INullableUDTwithoutStaticNull(string typeName) { }

	public static Exception InvalidAttributeValue(string name, string value) { }

	public static Exception InvalidDataColumnMapping(Type type) { }

	public static Exception InvalidDateTimeMode(DataSetDateTime mode) { }

	internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr) { }

	public static Exception InvalidField(string name) { }

	public static Exception InvalidKey(string name) { }

	public static Exception InValidNestedRelation(string childTableName) { }

	public static Exception InvalidOffsetLength() { }

	public static Exception InvalidParentNamespaceinNestedRelation(string childTableName) { }

	public static Exception InvalidPrefix(string name) { }

	public static Exception InvalidRemotingFormat(SerializationFormat mode) { }

	public static Exception InvalidRowBitPattern() { }

	public static Exception InvalidRowState(DataRowState state) { }

	public static Exception InvalidRowVersion() { }

	public static Exception InvalidSelector(string name) { }

	public static Exception InvalidSortString(string sort) { }

	public static Exception InvalidStorageType(TypeCode typecode) { }

	public static Exception IsDataSetAttributeMissingInSchema() { }

	public static Exception KeyColumnsIdentical() { }

	public static Exception KeyDuplicateColumns(string columnName) { }

	public static Exception KeyLengthMismatch() { }

	public static Exception KeyLengthZero() { }

	public static Exception KeyNoColumns() { }

	public static string KeysToString(Object[] keys) { }

	public static Exception KeyTableMismatch() { }

	public static Exception KeyTooManyColumns(int cols) { }

	public static Exception LongerThanMaxLength(DataColumn column) { }

	public static Exception LoopInNestedRelations(string tableName) { }

	public static string MaxLengthViolationText(string columnName) { }

	public static Exception MergeFailed(string name) { }

	public static Exception MergeMissingDefinition(string obj) { }

	public static Exception MismatchKeyLength() { }

	public static Exception MissingAttribute(string element, string attribute) { }

	public static Exception MissingAttribute(string attribute) { }

	public static Exception MissingRefer(string name) { }

	public static Exception MultipleParentRows(string tableQName) { }

	public static Exception MultipleParents() { }

	public static Exception MultipleTextOnlyColumns() { }

	public static Exception NamespaceNameConflict(string name) { }

	public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk) { }

	public static Exception NegativeMinimumCapacity() { }

	public static Exception NestedCircular(string name) { }

	public static Exception NoConstraintName() { }

	public static Exception NoCurrentData() { }

	public static Exception NonUniqueValues(string column) { }

	public static Exception NoOriginalData() { }

	public static Exception NoProposedData() { }

	public static Exception NoTableName() { }

	public static string NotAllowDBNullViolationText(string columnName) { }

	public static Exception NotOpen() { }

	public static Exception NullDataType() { }

	public static Exception NullKeyValues(string column) { }

	public static Exception NullRange() { }

	public static Exception NullValues(string column) { }

	public static Exception ParentOrChildColumnsDoNotHaveDataSet() { }

	public static Exception ParentTableMismatch() { }

	public static Exception PolymorphismNotSupported(string typeName) { }

	public static Exception ProblematicChars(char charValue) { }

	public static Exception RangeArgument(int min, int max) { }

	public static Exception ReadOnly(string column) { }

	public static Exception ReadOnlyAndExpression() { }

	public static Exception RecordStateRange() { }

	public static Exception RelationAlreadyExists() { }

	public static Exception RelationAlreadyInOtherDataSet() { }

	public static Exception RelationAlreadyInTheDataSet() { }

	public static Exception RelationChildKeyMissing(string rel) { }

	public static Exception RelationChildNameMissing(string rel) { }

	public static Exception RelationDataSetMismatch() { }

	public static Exception RelationDataSetNull() { }

	public static Exception RelationDoesNotExist() { }

	public static Exception RelationForeignRow() { }

	public static Exception RelationForeignTable(string t1, string t2) { }

	public static Exception RelationNestedReadOnly() { }

	public static Exception RelationNotInTheDataSet(string relation) { }

	public static Exception RelationOutOfRange(object index) { }

	public static Exception RelationParentNameMissing(string rel) { }

	public static Exception RelationTableKeyMissing(string rel) { }

	public static Exception RelationTableNull() { }

	public static Exception RelationTableWasRemoved() { }

	public static Exception RemoveExternalObject() { }

	public static Exception RemoveParentRow(ForeignKeyConstraint constraint) { }

	public static Exception RemovePrimaryKey(DataTable table) { }

	public static Exception RowAlreadyDeleted() { }

	public static Exception RowAlreadyInOtherCollection() { }

	public static Exception RowAlreadyInTheCollection() { }

	public static Exception RowAlreadyRemoved() { }

	public static Exception RowEmpty() { }

	public static Exception RowInsertMissing(string tableName) { }

	public static Exception RowInsertTwice(int index, string tableName) { }

	public static Exception RowNotInTheDataSet() { }

	public static Exception RowNotInTheTable() { }

	public static Exception RowOutOfRange(int index) { }

	public static Exception RowRemovedFromTheTable() { }

	public static Exception SelfnestedDatasetConflictingName(string table) { }

	internal static Exception SetDataSetNameConflicting(string name) { }

	internal static Exception SetDataSetNameToEmpty() { }

	public static Exception SetFailed(object value, DataColumn column, Type type, Exception innerException) { }

	public static Exception SetFailed(string name) { }

	public static Exception SetIListObject() { }

	public static Exception SetParentRowTableMismatch(string t1, string t2) { }

	public static Exception SimpleTypeNotSupported() { }

	public static Exception StorageSetFailed() { }

	public static Exception TableAlreadyInOtherDataSet() { }

	public static Exception TableAlreadyInTheDataSet() { }

	public static Exception TableCannotAddToSimpleContent() { }

	public static Exception TableCantBeNestedInTwoTables(string tableName) { }

	public static Exception TableForeignPrimaryKey() { }

	public static Exception TableInConstraint(DataTable table, Constraint constraint) { }

	public static Exception TableInRelation() { }

	public static Exception TableNotFound(string tableName) { }

	public static Exception TableNotInTheDataSet(string table) { }

	public static Exception TableOutOfRange(int index) { }

	public static Exception TablesInDifferentSets() { }

	private static void ThrowDataException(string error, Exception innerException) { }

	internal static void ThrowMultipleTargetConverter(Exception innerException) { }

	public static Exception TooManyIsDataSetAtributeInSchema() { }

	private static void TraceException(string trace, Exception e) { }

	internal static Exception TraceExceptionAsReturnValue(Exception e) { }

	internal static Exception TraceExceptionForCapture(Exception e) { }

	internal static Exception TraceExceptionWithoutRethrow(Exception e) { }

	public static Exception TypeNotAllowed(Type type) { }

	public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName) { }

	public static Exception UndefinedDatatype(string name) { }

	public static Exception UniqueAndExpression() { }

	public static Exception UniqueConstraintViolation() { }

	public static string UniqueConstraintViolationText(DataColumn[] columns, Object[] values) { }

	public static Exception ValueArrayLength() { }

}

