using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoUtils {

	public static void DrawRectangle(Rect rect, Color color) {

		Gizmos.color = color;

		Vector2 bottomLeft = rect.min;
		Vector2 topLeft = new Vector2 (rect.xMin, rect.yMax);
		Vector2 topRight = rect.max;
		Vector2 bottomRight = new Vector2 (rect.xMax, rect.yMin);

		Gizmos.DrawLine (bottomLeft, topLeft);
		Gizmos.DrawLine (topLeft, topRight);
		Gizmos.DrawLine (topRight, bottomRight);
		Gizmos.DrawLine (bottomRight, bottomLeft);

	}
}
