namespace UnityEngine.UI;

[AddComponentMenu("Layout/Grid Layout Group", 152)]
public class GridLayoutGroup : LayoutGroup
{
	internal enum Axis
	{
		Horizontal = 0,
		Vertical = 1,
	}

	internal enum Constraint
	{
		Flexible = 0,
		FixedColumnCount = 1,
		FixedRowCount = 2,
	}

	internal enum Corner
	{
		UpperLeft = 0,
		UpperRight = 1,
		LowerLeft = 2,
		LowerRight = 3,
	}

	[SerializeField]
	protected Corner m_StartCorner; //Field offset: 0x60
	[SerializeField]
	protected Axis m_StartAxis; //Field offset: 0x64
	[SerializeField]
	protected Vector2 m_CellSize; //Field offset: 0x68
	[SerializeField]
	protected Vector2 m_Spacing; //Field offset: 0x70
	[SerializeField]
	protected Constraint m_Constraint; //Field offset: 0x78
	[SerializeField]
	protected int m_ConstraintCount; //Field offset: 0x7C

	public Vector2 cellSize
	{
		 get { } //Length: 19
		 set { } //Length: 81
	}

	public Constraint constraint
	{
		 get { } //Length: 4
		 set { } //Length: 75
	}

	public int constraintCount
	{
		 get { } //Length: 4
		 set { } //Length: 85
	}

	public Vector2 spacing
	{
		 get { } //Length: 19
		 set { } //Length: 81
	}

	public Axis startAxis
	{
		 get { } //Length: 4
		 set { } //Length: 75
	}

	public Corner startCorner
	{
		 get { } //Length: 4
		 set { } //Length: 75
	}

	protected GridLayoutGroup() { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public virtual void CalculateLayoutInputVertical() { }

	public Vector2 get_cellSize() { }

	public Constraint get_constraint() { }

	public int get_constraintCount() { }

	public Vector2 get_spacing() { }

	public Axis get_startAxis() { }

	public Corner get_startCorner() { }

	public void set_cellSize(Vector2 value) { }

	public void set_constraint(Constraint value) { }

	public void set_constraintCount(int value) { }

	public void set_spacing(Vector2 value) { }

	public void set_startAxis(Axis value) { }

	public void set_startCorner(Corner value) { }

	private void SetCellsAlongAxis(int axis) { }

	public virtual void SetLayoutHorizontal() { }

	public virtual void SetLayoutVertical() { }

}

