let mapSelector = document.querySelector('#map');
let dealerLocatorList = document.querySelector('.dealer-locator-list .list');
let map, lastItemClickedIndex, locations, infoWindow, markers = [];
let mapOption = {
	zoom: 12,
	// styles: [
	// 	{
	// 		"featureType": "all",
	// 		"elementType": "labels.text.fill",
	// 		"stylers": [
	// 			{
	// 				"saturation": 36
	// 			},
	// 			{
	// 				"color": "#000000"
	// 			},
	// 			{
	// 				"lightness": 40
	// 			}
	// 		]
	// 	},
	// 	{
	// 		"featureType": "all",
	// 		"elementType": "labels.text.stroke",
	// 		"stylers": [
	// 			{
	// 				"visibility": "on"
	// 			},
	// 			{
	// 				"color": "#000000"
	// 			},
	// 			{
	// 				"lightness": 16
	// 			}
	// 		]
	// 	},
	// 	{
	// 		"featureType": "all",
	// 		"elementType": "labels.icon",
	// 		"stylers": [
	// 			{
	// 				"visibility": "off"
	// 			}
	// 		]
	// 	},
	// 	{
	// 		"featureType": "administrative",
	// 		"elementType": "geometry.fill",
	// 		"stylers": [
	// 			{
	// 				"color": "#000000"
	// 			},
	// 			{
	// 				"lightness": 20
	// 			}
	// 		]
	// 	},
	// 	{
	// 		"featureType": "administrative",
	// 		"elementType": "geometry.stroke",
	// 		"stylers": [
	// 			{
	// 				"color": "#000000"
	// 			},
	// 			{
	// 				"lightness": 17
	// 			},
	// 			{
	// 				"weight": 1.2
	// 			}
	// 		]
	// 	},
	// 	{
	// 		"featureType": "landscape",
	// 		"elementType": "geometry",
	// 		"stylers": [
	// 			{
	// 				"color": "#000000"
	// 			},
	// 			{
	// 				"lightness": 20
	// 			}
	// 		]
	// 	},
	// 	{
	// 		"featureType": "poi",
	// 		"elementType": "geometry",
	// 		"stylers": [
	// 			{
	// 				"color": "#000000"
	// 			},
	// 			{
	// 				"lightness": 21
	// 			}
	// 		]
	// 	},
	// 	{
	// 		"featureType": "road.highway",
	// 		"elementType": "geometry.fill",
	// 		"stylers": [
	// 			{
	// 				"color": "#000000"
	// 			},
	// 			{
	// 				"lightness": 17
	// 			}
	// 		]
	// 	},
	// 	{
	// 		"featureType": "road.highway",
	// 		"elementType": "geometry.stroke",
	// 		"stylers": [
	// 			{
	// 				"color": "#000000"
	// 			},
	// 			{
	// 				"lightness": 29
	// 			},
	// 			{
	// 				"weight": 0.2
	// 			}
	// 		]
	// 	},
	// 	{
	// 		"featureType": "road.arterial",
	// 		"elementType": "geometry",
	// 		"stylers": [
	// 			{
	// 				"color": "#000000"
	// 			},
	// 			{
	// 				"lightness": 18
	// 			}
	// 		]
	// 	},
	// 	{
	// 		"featureType": "road.local",
	// 		"elementType": "geometry",
	// 		"stylers": [
	// 			{
	// 				"color": "#000000"
	// 			},
	// 			{
	// 				"lightness": 16
	// 			}
	// 		]
	// 	},
	// 	{
	// 		"featureType": "transit",
	// 		"elementType": "geometry",
	// 		"stylers": [
	// 			{
	// 				"color": "#000000"
	// 			},
	// 			{
	// 				"lightness": 19
	// 			}
	// 		]
	// 	},
	// 	{
	// 		"featureType": "water",
	// 		"elementType": "geometry",
	// 		"stylers": [
	// 			{
	// 				"color": "#952d2d"
	// 			},
	// 			{
	// 				"lightness": 17
	// 			}
	// 		]
	// 	}
	// ]
};

const addMarkers = () => {
	markers = [];
	const bounds = new google.maps.LatLngBounds();
	locations.forEach((location, index) => {
		let locationLatLng = new google.maps.LatLng(location.lat, location.lng);
		let marker = new google.maps.Marker({
			map: map,
			title: location.title,
			position: locationLatLng,
			icon: location.icon,
		});
		bounds.extend(marker.position);
		markers.push(marker);
		showInfoMarkerOnMap(marker, index);
	});

	map.fitBounds(bounds);
};

const showInfoMarkerOnMap = (marker, index) => {
	google.maps.event.addListener(marker, 'click', function() {
		infoWindow.setContent(`
				<h3>${locations[index].title}</h3>
				<p>${locations[index].address}</p>
				<p>${locations[index].phone}</p>
			`);
		lastItemClickedIndex = index;
		infoWindow.open(map, marker);
		map.panTo(marker.getPosition());
		map.setZoom(12);
	})
	google.maps.event.addListener(map, 'click', function() {
		infoWindow.close();
	})
};

const getLocationList = () => {
	if (dealerLocatorList) {
		// dealerLocatorList.innerHTML = '';
		// markers.forEach((marker, index) => {
		// 	if (map.getBounds().contains(marker.getPosition())) {
		// 		const newMarker = document.createElement('div');
		// 		newMarker.classList.add('dealer-locator-item');
		// 		newMarker.innerHTML = `
		// 				<h3>${locations[index].title}</h3>
		// 				<p>${locations[index].address}</p>
		// 				<p>${locations[index].phone}</p>
		// 			`;
		// 		newMarker.setAttribute('marker-id', `${index}`);
		// 		newMarker.addEventListener('click', () => {
		// 			lastItemClickedIndex = index;
		// 			const markerIndex = newMarker.getAttribute('marker-id');
		// 			google.maps.event.trigger(markers[markerIndex], 'click');
		// 		});
		// 		dealerLocatorList.appendChild(newMarker);
		// 	}
		// });

		dealerLocatorList.innerHTML = '';
		markers.forEach((marker, index) => {
			const newMarker = document.createElement('div');
			newMarker.classList.add('dealer-locator-item');
			newMarker.innerHTML =
				`
				<h3>${locations[index].title}</h3>
				<p>${locations[index].address}</p>
				<p>${locations[index].phone}</p>
			`;
			newMarker.setAttribute('marker-id', `${index}`);
			newMarker.addEventListener('click', () => {
				lastItemClickedIndex = index;
				const markerIndex = newMarker.getAttribute('marker-id');
				google.maps.event.trigger(markers[markerIndex], 'click');
			});
			dealerLocatorList.appendChild(newMarker);
		})
	}
};

const initialize = () => {
	locations = locationsInput;
	infoWindow = new google.maps.InfoWindow();
	map = new google.maps.Map(mapSelector, mapOption);
	addMarkers();
	let listener = google.maps.event.addListener(map, 'idle', () => {
		if (map.getZoom() > 12) {
			map.setZoom(12);
		}
		google.maps.event.removeListener(listener);
	});
	google.maps.event.addListener(map, 'bounds_changed', getLocationList);
};

if (mapSelector) {
	google.maps.event.addDomListener(window, 'load', initialize);
	if (dealerLocatorList) {
		getLocationList();
	}
}