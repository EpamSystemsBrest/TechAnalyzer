$.getJSON("/scripts/PlatformStatus.json", function(json) {
var arr = json.features;  

var React = window.React = require('react'),    
    mountNode = document.getElementById("app");
    
var FeaturesList = React.createClass({ 	
  render: function() {		
  	var createFeatures = function(item) {			
			var Spec = React.createClass({				
				render: function(){
					var iconClassName = "icon icon-"+item.spec.organization;
					return(
						<li>
							<a href={item.spec.link}>
								<span className={iconClassName}></span>
								{item.spec.status}
							</a>
						</li>
					)
				}
			});
			
			var Msdn = React.createClass({
				render: function(){
					return(
						<li>
							<a href={item.docs.msdn}>
								<span className="icon icon-msdn"></span>
								MSDN
							</a>
						</li>
					)
				}
			});
			
			var Wpd = React.createClass({
				render: function(){
					return(
						<li>
							<a href={item.docs.wpd}>
								<span className="icon icon-webplatform"></span>
								WebPlatform
							</a>
						</li>
					)
				}
			});
			
			var Info = React.createClass({
				render: function(){
					var msdn, wpd;
					if (item.docs.msdn != undefined && item.docs.msdn != '') msdn = <Msdn />;
					if (item.docs.wpd != undefined && item.docs.wpd != '') wpd = <Wpd />
					
					return(
						<ul className="info">
						  <Spec />
						  {msdn}
							{wpd}
						</ul>						
					)
				}
			});			
			
			var createSupport = function(propName) {
				var Link = React.createClass({
					render: function(){
						return(
							<a href={item.browsers[propName].link}></a>
						)
					}
				});
				
				var iconClass = " icon icon-" + propName;
				
				var status;				
				switch(item.browsers[propName].status) {
					case 'Shipped' :
						status = ' implemented';
						break;
					case 'In Development' :
						status = ' indevelopment'
						break;
					default:
						status = ' ';
				}
				
				var title = item.browsers[propName].status + ' by ' + propName;
				var browserClass = 'browser' + iconClass + status;
				
				var statusLink;
				if (item.browsers[propName].link != null){
					statusLink = <Link />
				}
				
				return (
					<li className={browserClass} title={title}>
						{statusLink}
					</li>
				);	
			};
			
			var browsersArr = [];
			for(browser in item.browsers)
				browsersArr.push(browser);
				
    	return (
				<li className='feature jumbotron'>			
				  <h4>{item.name} - {item.category}</h4>
					<p>{item.summary}</p>	
					<div className="urls">
				  	<Info />
				  	<ul className='browsers'>
							{browsersArr.map(createSupport)}
						</ul>				
					</div>
				</li>					
			);
    };	
		
    return (
    	<div>
      	<h3 className="jumbotron search">
					Features:
					<input type="text" className='input' id="input" />
					<select id="select">
						<option>Name</option>
						<option>Class</option>
					</select>
				</h3>
        <ul className='features'>{arr.map(createFeatures)}</ul>
      </div>
    );
  }    
});

var FeaturesApp = React.createClass({
	componentDidMount: function() {
		var input = document.getElementById('input');
		var select = document.getElementById('select');	
		
		$.getScript("/scripts/ui/filter.js", function(){	
			input.onkeyup = filter;
			select.onchange = filter;
			
			if (window.location.hash == "#/") return;
			input.value = window.location.hash.slice(2);
			input.onkeyup();
		});
	},
  render: function() {
    return (    
    	<div className='stats'>    		
       	<FeaturesList />        
    	</div>   
    );
  }
});

React.render(<FeaturesApp />, mountNode);    
});