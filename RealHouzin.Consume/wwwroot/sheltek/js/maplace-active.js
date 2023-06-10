$(function() {
               




            var LocsA = [
                {
                    lat: 40.740178,
                    lon: -74.190194,
                    title: 'Property 1',
                    html: [ '<div class="map-property">',
                            '<a href="properties-details.html"><img src="images/flat/1.jpg" alt=""></a>',
                            '<h6><a href="properties-details.html">Friuli-Venezia Giulia</a></h6>',
                            '<h5>$52,354</h5>',
                            '<p>568 E 1st Ave, Miami</p>',
                            '</div>'
                        ].join(''),
                    icon: 'images/icons/map-marker-2.png',
                    animation: google.maps.Animation.BOUNCE
                },
                {
                    lat: 40.733617,
                    lon: -74.171150,
                    title: 'Property 2',
                    html: [ '<div class="map-property">',
                            '<a href="properties-details.html"><img src="images/flat/2.jpg" alt=""></a>',
                            '<h6><a href="properties-details.html">Radison de Villa</a></h6>',
                            '<h5>$42,354</h5>',
                            '<p>450 E 1st Ave, New Jersey</p>',
                            '</div>'
                        ].join(''),
                    icon: 'images/icons/map-marker-2.png',
                    animation: google.maps.Animation.BOUNCE
                },
                {
                    lat: 40.743011,
                    lon: -74.247100,
                    title: 'Property 3',
                    html: [ '<div class="map-property">',
                            '<a href="properties-details.html"><img src="images/flat/3.jpg" alt=""></a>',
                            '<h6><a href="properties-details.html">Friuli-Venezia Giulia</a></h6>',
                            '<h5>$52,354</h5>',
                            '<p>568 E 1st Ave, Miami</p>',
                            '</div>'
                        ].join(''),
                    icon: 'images/icons/map-marker-2.png',
                    animation: google.maps.Animation.BOUNCE
                },
                {
                    lat: 40.711150,
                    lon: -74.214998,
                    title: 'Property 4',
                    html: [ '<div class="map-property">',
                            '<a href="properties-details.html"><img src="images/flat/4.jpg" alt=""></a>',
                            '<h6><a href="properties-details.html">Friuli-Venezia Giulia</a></h6>',
                            '<h5>$52,354</h5>',
                            '<p>568 E 1st Ave, Miami</p>',
                            '</div>'
                        ].join(''),
                    icon: 'images/icons/map-marker-2.png',
                    animation: google.maps.Animation.BOUNCE
                },
                {
                    lat: 40.690010,
                    lon: -74.151753,
                    title: 'Property 5',
                    html: [ '<div class="map-property">',
                            '<a href="properties-details.html"><img src="images/flat/5.jpg" alt=""></a>',
                            '<h6><a href="properties-details.html">Friuli-Venezia Giulia</a></h6>',
                            '<h5>$52,354</h5>',
                            '<p>568 E 1st Ave, Miami</p>',
                            '</div>'
                        ].join(''),
                    icon: 'images/icons/map-marker-2.png',
                    animation: google.maps.Animation.BOUNCE
                },
                {
                    lat: 40.697590,
                    lon: -74.263164,
                    title: 'Property 6',
                    html: [ '<div class="map-property">',
                            '<a href="properties-details.html"><img src="images/flat/6.jpg" alt=""></a>',
                            '<h6><a href="properties-details.html">Friuli-Venezia Giulia</a></h6>',
                            '<h5>$52,354</h5>',
                            '<p>568 E 1st Ave, Miami</p>',
                            '</div>'
                        ].join(''),
                    icon: 'images/icons/map-marker-2.png',
                    animation: google.maps.Animation.BOUNCE
                },
                {
                    lat: 40.729979,
                    lon: -74.271992,
                    title: 'Property 7',
                    html: [ '<div class="map-property">',
                            '<a href="properties-details.html"><img src="images/flat/7.jpg" alt=""></a>',
                            '<h6><a href="properties-details.html">Friuli-Venezia Giulia</a></h6>',
                            '<h5>$52,354</h5>',
                            '<p>568 E 1st Ave, Miami</p>',
                            '</div>'
                        ].join(''),
                    icon: 'images/icons/map-marker-2.png',
                    animation: google.maps.Animation.BOUNCE
                },
                {
                    lat: 40.749702,
                    lon: -74.163631,
                    title: 'Property 8',
                    html: [ '<div class="map-property">',
                            '<a href="properties-details.html"><img src="images/flat/8.jpg" alt=""></a>',
                            '<h6><a href="properties-details.html">Friuli-Venezia Giulia</a></h6>',
                            '<h5>$52,354</h5>',
                            '<p>568 E 1st Ave, Miami</p>',
                            '</div>'
                        ].join(''),
                    icon: 'images/icons/map-marker-2.png',
                    animation: google.maps.Animation.BOUNCE
                },
                {
                    lat: 40.718971,
                    lon: -74.323219,
                    title: 'Property 9',
                    html: [ '<div class="map-property">',
                            '<a href="properties-details.html"><img src="images/flat/9.jpg" alt=""></a>',
                            '<h6><a href="properties-details.html">Friuli-Venezia Giulia</a></h6>',
                            '<h5>$52,354</h5>',
                            '<p>568 E 1st Ave, Miami</p>',
                            '</div>'
                        ].join(''),
                    icon: 'images/icons/map-marker-2.png',
                    animation: google.maps.Animation.BOUNCE
                },
                {
                    lat: 40.748350,
                    lon: -74.323219,
                    title: 'Property 10',
                    html: [ '<div class="map-property">',
                            '<a href="properties-details.html"><img src="images/flat/1.jpg" alt=""></a>',
                            '<h6><a href="properties-details.html">Friuli-Venezia Giulia</a></h6>',
                            '<h5>$52,354</h5>',
                            '<p>568 E 1st Ave, Miami</p>',
                            '</div>'
                        ].join(''),
                    icon: 'images/icons/map-marker-2.png',
                    animation: google.maps.Animation.BOUNCE
                },
                {
                    lat: 40.740178,
                    lon: -74.190194,
                    title: 'Property 11',
                    html: [ '<div class="map-property">',
                            '<a href="properties-details.html"><img src="images/flat/2.jpg" alt=""></a>',
                            '<h6><a href="properties-details.html">Friuli-Venezia Giulia</a></h6>',
                            '<h5>$52,354</h5>',
                            '<p>568 E 1st Ave, Miami</p>',
                            '</div>'
                        ].join(''),
                    icon: 'images/icons/map-marker-2.png',
                    animation: google.maps.Animation.BOUNCE
                }


            
                
            ];
            new Maplace({
                locations: LocsA,
                controls_on_map: true,
                map_options: {
                    zoom: 13,
                    scrollwheel: false,
                    stopover: true
                }
            }).Load();

        });