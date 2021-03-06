﻿//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// ManagerAlgoritmos.cs (04/06/2018)											\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Manager general de los algoritmos							\\
// Fecha Mod:		04/06/2018													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
#endregion

namespace MoonAntonio
{
	/// <summary>
	/// <para>Manager general de los algoritmos.</para>
	/// </summary>
	public class ManagerAlgoritmos : MonoBehaviour 
	{
		#region Variables Publicas
		/// <summary>
		/// <para>Todas las escenas.</para>
		/// </summary>
		public List<Transform> escenas = new List<Transform>();
		public List<RectTransform> posUI = new List<RectTransform>();
		#endregion

		#region Variables Publicas UI
		public Text headerOrdenacion;
		public Text descripcionOrdenacion;
		public Slider efectividadOrdenacion;
		public Slider velocidadOrdenacion;
		public Toggle randomOrdenacion;
		public Text headerBusqueda;
		public Text descripcionBusqueda;
		public Slider efectividadBusqueda;
		public Slider velocidadBusqueda;
		public Toggle randomBusqueda;
		#endregion

		#region Variables Privadas
		public bool tempInit = false;
		public List<int> numeracion = new List<int>(9);
		#endregion

		#region Variables Protegidas
		/// <summary>
		/// <para>Id del algoritmo.</para>
		/// </summary>
		public int idAlgoritmo = 0;

		public List<RectTransform> posUISave = new List<RectTransform>();
		#endregion

		#region Inicializadores
		private void Start()
		{
			foreach (RectTransform n in posUI)
			{
				posUISave.Add(n);
			}
		}
		#endregion

		#region Actualizadores
		private void Update()
		{
			if (tempInit) return;
			switch (idAlgoritmo)
			{
				case 0:
					
					break;

				case 1:
					break;

				case 2:
					break;

				case 3:
					break;

				case 4:
					break;

				case 5:
					break;

				default:
					break;
			}
		}
		#endregion


		#region Metodos Publicos
		/// <summary>
		/// <para>Selecciona el id del algoritmo.</para>
		/// </summary>
		/// <param name="id"></param>
		public void SetID(int id)
		{
			tempInit = false;
			idAlgoritmo = id;
			ResetEscena(id);
		}

		public void IniciarAlgoritmo()
		{
			tempInit = true;
		}

		public void Desordenar()
		{
			for (int n = 0; n < numeracion.Count; n++)
			{
				numeracion[n] = Random.Range(0, 9);
				posUI[n].position = posUISave[numeracion[n]].position;
			}
		}
		#endregion

		#region Metodos Privados
		/// <summary>
		/// <para>Resetea la escena.</para>
		/// </summary>
		/// <param name="id"></param>
		private void ResetEscena(int id)
		{
			foreach (Transform escena in escenas)
			{
				escena.gameObject.SetActive(false);
			}

			switch (id)
			{
				case 0:
					escenas[0].gameObject.SetActive(true);
					break;

				case 1:
					escenas[1].gameObject.SetActive(true);
					break;

				case 2:
					escenas[2].gameObject.SetActive(true);
					break;

				case 3:
					escenas[3].gameObject.SetActive(true);
					break;

				case 4:
					escenas[4].gameObject.SetActive(true);
					break;

				case 5:
					escenas[5].gameObject.SetActive(true);
					break;

				default:
					escenas[0].gameObject.SetActive(true);
					break;
			}

			InitEscena(id);
		}

		/// <summary>
		/// <para>Inicializa la escena seleccionada.</para>
		/// </summary>
		/// <param name="id"></param>
		private void InitEscena(int id)
		{
			switch (id)
			{
				case 0:
					headerOrdenacion.text = "Inserción";
					descripcionOrdenacion.text = "Es una manera muy natural de ordenar para un ser humano, y puede usarse fácilmente para ordenar un mazo de cartas numeradas en forma arbitraria. Requiere O(n²) operaciones para ordenar una lista de n elementos.";
					efectividadOrdenacion.value = 50.2f;
					velocidadBusqueda.value = 20.2f;
					break;

				case 1:
					headerOrdenacion.text = "Burbuja";
					descripcionOrdenacion.text = "Funciona revisando cada elemento de la lista que va a ser ordenada con el siguiente, intercambiándolos de posición si están en el orden equivocado.";
					efectividadOrdenacion.value = 70.7f;
					velocidadBusqueda.value = 60.6f;
					break;

				case 2:
					headerOrdenacion.text = "Selección";
					descripcionOrdenacion.text = "Este algoritmo realiza muchas menos operaciones intercambiar() que el de la burbuja, por lo que lo mejora en algo.";
					efectividadOrdenacion.value = 90.9f;
					velocidadBusqueda.value = 90.9f;
					break;

				case 3:
					headerOrdenacion.text = "Montones";
					descripcionOrdenacion.text = "Este algoritmo consiste en almacenar todos los elementos del vector a ordenar en un monton, y luego extraer el nodo que queda como nodo raíz del montículo en sucesivas iteraciones obteniendo el conjunto ordenado.";
					efectividadOrdenacion.value = 80.8f;
					velocidadBusqueda.value = 70.7f;
					break;

				case 4:
					headerBusqueda.text = "A*";
					descripcionBusqueda.text = "A* encuentra, siempre y cuando se cumplan unas determinadas condiciones, el camino de menor coste entre un nodo origen y uno objetivo.";
					efectividadBusqueda.value = 50.5f;
					velocidadBusqueda.value = 90.9f;
					break;

				case 5:
					headerBusqueda.text = "Dijkstra";
					descripcionBusqueda.text = "La idea subyacente en este algoritmo consiste en ir explorando todos los caminos más cortos que parten del vértice origen y que llevan a todos los demás vértices.";
					efectividadBusqueda.value = 80.8f;
					velocidadBusqueda.value = 50.5f;
					break;

				default:
					headerOrdenacion.text = "Inserción";
					descripcionOrdenacion.text = "Es una manera muy natural de ordenar para un ser humano, y puede usarse fácilmente para ordenar un mazo de cartas numeradas en forma arbitraria. Requiere O(n²) operaciones para ordenar una lista de n elementos.";
					efectividadOrdenacion.value = 5.2f;
					velocidadBusqueda.value = 2.2f;
					break;
			}
		}
		#endregion
	}
}