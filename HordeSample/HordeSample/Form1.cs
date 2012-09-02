using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;

namespace HordeSample
{
	public partial class Form1 : Form
	{
		#region 定数

		private const int BLOCK_SIZE = 8;
		private const int THRESHOLD = 1000;

		private const String MINUS_IMAGE_FILENAME = "minus";
		private const String TRANS_IMAGE_FILENAME = "trans";
		private const String LIFE_IMAGE_FILENAME = "lp_00";

		#endregion

		#region 変数

		private int _inputValue = 0;
		private Assembly _assembly = Assembly.GetExecutingAssembly();
		private ResourceManager _rm = null;
		private List<PictureBox> _lifePicBoxes = new List<PictureBox>();

		private int _initialLifePoint = 20;
		/// <summary>
		/// ライフポイントの初期値
		/// </summary>
		public int InitialLifePoint
		{
			get { return _initialLifePoint; }
			set { _initialLifePoint = value; }
		}
		private int _lifePoint = 0;
		/// <summary>
		/// ライフポイント
		/// </summary>
		public int LifePoint
		{
			get { return _lifePoint; }
			set { _lifePoint = value; }
		}

		private bool _isNumberInputtedLast = false;
		/// <summary>
		/// 最後に入力したのが数字かどうか
		/// </summary>
		public bool IsNumberInputtedLast
		{
			get { return _isNumberInputtedLast; }
			set { _isNumberInputtedLast = value; }
		}

		#endregion

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Form1()
		{
			InitializeComponent();

			_rm = new ResourceManager("HordeSample.Properties.Resources", _assembly);

			_lifePicBoxes.Add(life_1_picturebox);
			_lifePicBoxes.Add(life_10_picturebox);
			_lifePicBoxes.Add(life_100_picturebox);
			_lifePicBoxes.Add(lifeMinus_picturebox);
			for (int i = 0; i < _lifePicBoxes.Count; i++ )
			{
				_lifePicBoxes[i].Parent = lifeBG_picturebox;
				_lifePicBoxes[i].Left = (_lifePicBoxes.Count - i - 1) * (_lifePicBoxes[i].Width + BLOCK_SIZE) + BLOCK_SIZE;
				_lifePicBoxes[i].Top = BLOCK_SIZE;
			}

			InitLifePoint();
		}

		#region 初期化

		/// <summary>
		/// 入力値を初期化する
		/// </summary>
		private void InitInputValue()
		{
			_inputValue = 0;
			UpdateInputLabel(0);
		}

		/// <summary>
		/// ライフポイントを初期化する
		/// </summary>
		private void InitLifePoint()
		{
			// ライフポイントを更新
			LifePoint = InitialLifePoint;
			// ライフポイントの画像を更新
			SetLifePoint(LifePoint);
		}

		/// <summary>
		/// ライフポイントの初期値を設定する
		/// </summary>
		/// <param name="value"></param>
		private void SetInitialLifePoint(int value)
		{
			// 初期ライフの更新
			InitialLifePoint = value;
			// 入力値の初期化
			InitInputValue();
			// ライフポイントの更新
			InitLifePoint();
		}

		#endregion

		#region リセット

		/// <summary>
		/// リセット
		/// </summary>
		private void Reset()
		{
			InitLifePoint();
			InitInputValue();
		}

		#endregion

		#region 各入力に対する操作

		/// <summary>
		/// 値の時の操作
		/// </summary>
		/// <param name="value"></param>
		private void OperateValue(KeyEventArgs e)
		{
			Keys key = e.KeyCode;

			if (THRESHOLD <= _inputValue * 10)
			{
				return;
			}

			int convertedValue = ConvertKeyValue2Value(key);
			if (convertedValue == -1)
			{
				;
			}
			else
			{
				_inputValue = _inputValue * 10 + convertedValue;
				UpdateInputLabel(_inputValue);
			}
		}

		/// <summary>
		/// その他の時の操作
		/// </summary>
		/// <param name="key"></param>
		private void OperateOthers(KeyEventArgs e)
		{
			Keys key = e.KeyCode;

			switch (key)
			{
				case Keys.I:
					// 数字 + i ： 初期ライフ更新
					if (IsNumberInputtedLast)
					{
						SetInitialLifePoint(_inputValue);
					}
					break;
				case Keys.R:
					// Ctrl + R ： リセット
					if((e.Modifiers & Keys.Control) == Keys.Control)
					{
						Reset();
					}
					break;
				default:
					break;
			}
		}

		/// <summary>
		/// 矢印の時の操作
		/// </summary>
		/// <param name="value"></param>
		private void OperateArrow(KeyEventArgs e)
		{
			Keys key = e.KeyCode;

			switch (key)
			{
				case Keys.Up:
					LifePoint += _inputValue;
					// 上限に合わせる
					if (THRESHOLD <= LifePoint)
					{
						LifePoint = (THRESHOLD - 1);
					}
					// ライフポイントに設定
					SetLifePoint(LifePoint);
					break;
				case Keys.Down:
					LifePoint -= _inputValue;
					// 下限に合わせる
					if (LifePoint <= -THRESHOLD)
					{
						LifePoint = -1 * (THRESHOLD - 1);
					}
					// ライフポイントに設定
					SetLifePoint(LifePoint);
					break;
				case Keys.Right:
					break;
				case Keys.Left:
					break;
				default:
					break;
			}
		}

		/// <summary>
		/// エスケープキーの時の操作
		/// </summary>
		/// <param name="key"></param>
		private void OperateEscape(KeyEventArgs e)
		{
			_inputValue /= 10;
			UpdateInputLabel(_inputValue);
		}

		#endregion

		#region GUI操作

		/// <summary>
		/// 数値を元にライフポイントの画像を設定する
		/// </summary>
		/// <param name="lifePoint"></param>
		private void SetLifePoint(int lifePoint)
		{
			int[] values = GetEachPlaceValues(lifePoint);
			Bitmap[] bmps = {null, null, null, null};

			// マイナスを付けるか付けないか
			bmps[0] = (Bitmap)_rm.GetObject((values[0] == -1) ? MINUS_IMAGE_FILENAME : TRANS_IMAGE_FILENAME);
			bmps[0].MakeTransparent(bmps[0].GetPixel(0, 0));
			lifeMinus_picturebox.Image = bmps[0];

			// 各桁の数値の設定
			for (int i = 1; i < bmps.Length; i++)
			{
				bmps[i] = (Bitmap)_rm.GetObject(LIFE_IMAGE_FILENAME + values[i]);
				bmps[i].MakeTransparent(bmps[i].GetPixel(0, 0));
				_lifePicBoxes[i - 1].Image = bmps[i];
			}
		}

		/// <summary>
		/// 入力値を更新する
		/// </summary>
		/// <param name="inputValue"></param>
		private void UpdateInputLabel(int inputValue)
		{
			int[] values = GetEachPlaceValues(inputValue);

			inputValue_1_label.Text = values[1].ToString();
			inputValue_10_label.Text = values[2].ToString();
			inputValue_100_label.Text = values[3].ToString();
		}

		#endregion

		#region 計算

		/// <summary>
		/// キーコードから数値に変換する
		/// </summary>
		/// <param name="keyValue"></param>
		/// <returns></returns>
		private int ConvertKeyValue2Value(Keys key)
		{
			int result = 0;

			if ((Keys.D0 <= key) && (key <= Keys.D9))
			{
				result = key - Keys.D0;
			}
			else if ((Keys.NumPad0 <= key) && (key <= Keys.NumPad9))
			{
				result = key - Keys.NumPad0;
			}
			else
			{
				result = -1;
			}

			return result;
		}

		/// <summary>
		/// 各桁の数値を求める
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		private int[] GetEachPlaceValues(int value)
		{
			int[] result = {0, 0, 0, 0};
			if (value < 0)
			{
				result[0] = -1;
			}
			value = Math.Abs(value);
			result[3] = value / 100;
			result[2] = (value - result[3]* 100) / 10;
			result[1] = value - (result[3] * 100) - (result[2] * 10);

			return result;
		}

		#endregion

		#region イベント

		#region キー入力

		/// <summary>
		/// キー入力イベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			Keys key = e.KeyCode;

			if (((Keys.D0 <= key) && (key <= Keys.D9)) ||
				((Keys.NumPad0 <= key) && (key <= Keys.NumPad9)))
			{
				// 数字
				OperateValue(e);

				IsNumberInputtedLast = true;
			}
			else
			{
				if (key == Keys.Escape)
				{
					// Esc
					OperateEscape(e);
				}
				else if ((key == Keys.Up) || (key == Keys.Down) || (key == Keys.Right) || (key == Keys.Left))
				{
					// 矢印
					OperateArrow(e);
				}
				else
				{
					// その他
					OperateOthers(e);
				}

				InitInputValue();
				IsNumberInputtedLast = false;
			}
		}

		#endregion

		#endregion
	}
}
