function speed(speed, area){
    const motorWayLimit=130;
    const interstateLimit=90;
    const cityLimit=50;
    const residentLimit=20;
    let difference=0;
    let status='';
    switch(area) {
        case 'motorway':
          if(speed>motorWayLimit){
            difference=speed-motorWayLimit;
            if(difference<=20){
                status='speeding';
            }else if(difference>20&&difference<=40){
                status='excessive speeding';
            }
            else if(difference>40){
                status='reckless driving';
            }
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${motorWayLimit} - ${status}`);
                
            }
            
        else {
          console.log(`Driving ${speed} km/h in a ${motorWayLimit} zone`);
        }
          break;
        case 'interstate':
            if(speed>interstateLimit){
                difference=speed-interstateLimit;
                if(difference<=20){
                    status='speeding';
                }else if(difference>20&&difference<=40){
                    status='excessive speeding';
                }
                else if(difference>40){
                    status='reckless driving';
                }
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${interstateLimit} - ${status}`);
                    
                }
                
            else {
              console.log(`Driving ${speed} km/h in a ${interstateLimit} zone`);
            }
              break;
        case 'city':
            if(speed>cityLimit){
                difference=speed-cityLimit;
                if(difference<=20){
                    status='speeding';
                }else if(difference>20&&difference<=40){
                    status='excessive speeding';
                }
                else if(difference>40){
                    status='reckless driving';
                }
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${cityLimit} - ${status}`);
                    
                }
                
            else {
              console.log(`Driving ${speed} km/h in a ${cityLimit} zone`);
            }
              break;
        case 'residential':
            if(speed>residentLimit){
                difference=speed-residentLimit;
                if(difference<=20){
                    status='speeding';
                }else if(difference>20&&difference<=40){
                    status='excessive speeding';
                }
                else if(difference>40){
                    status='reckless driving';
                }
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${residentLimit} - ${status}`);
                    
                }
                
            else {
              console.log(`Driving ${speed} km/h in a ${residentLimit} zone`);
            }
              break;
        default:
          // code block
      }
    
}
speed(200, 'motorway');
