//window객체는 웹브라우저 전체를 의미한다고 보면 된다.
//398p내용 보기 
//많이 쓰이는건 documnet객체를 많이씀 (window아래 내용의미)

window.addEventListener('load',
    function () {
        const sounds = document.querySelectorAll(".sound");

        const pads = document.querySelectorAll(".pads div");
        //visual 
        const visual = document.querySelector('.visual')

        //클래스 이름이 title인 태그 하나 선택
        const title = document.querySelector('.title')

        //초기화 할떄 쓰임
        const color = ["rgb(231, 36, 10)", "yellow", "green", "blue", "rgb(51, 22, 22)", "rgb(150, 12, 143)"];

        sounds.forEach(
            function (snd) {


                snd.onended = function () {
                    cisual.innerHTML = "";
                    title.innerHTML = "";
                }
            }
        );

        pads.forEach( function(pad, index) {
            pad.addEventListener('click', function(){
                //기존에 재생되는 음악을 중지 시켜야 한다.
               sounds.forEach(function(inx) {
                //console.log(inx);
                inx.pause();
               });
               if(sounds[index]){
                sounds[index].currentTime = 0;
                sounds[index].play();

                //뮤직 제목을 출력해 준다.
                //console.log(sounds[index].src) ;
                //spilt (값을 잘라줌),첫번쨰는 파일경로가나옴
                //첫번째부터는 파일명이 나옴
                const strArray = sounds[index].src.split("sound/");
                title.innerHTML = strArray[1];
               }
               
                //볼만들고 애니메이션 하기
                createBubbles(index);
            });
        });

        const createBubbles = function(index)
        {
            visual.innerHTML = "";

            const bubble =document.createElement("div");
            visual.appendChild(bubble);
            
            console.log(color[index]);
            console.log(index);
            bubble.style.backgroundColor=color[index];
            bubble.style.top='300px';

            bubble.style.animation='animation 2000ms linear infinite both';
        }

    }
);