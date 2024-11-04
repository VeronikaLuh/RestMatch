"use client";

import Image from "next/image";
import heartIcon from "../../../public/assets/images/match/icon-heart.svg";
import editIcon from "../../../public/assets/images/match/icon-edit.svg";
import arrowIcon from "../../../public/assets/images/match/icon-back.svg";
import imageArrowIcon from "../../../public/assets/images/match/icon-forward.svg";
import Stat from "@/components/info/Stat";
import { useState } from "react";
import { iconUrl } from "@/utils/constants";

export default function Match() {
  return (
    <div className="flex justify-center pt-5 pb-5 bg-[#9F784E]">
      <Card />
    </div>
  );
}

function Card() {
  const countOfPhoto = 3;
  const [currentPhotoIndex, setCurrentPhotoIndex] = useState(0);

  return (
    <div className="flex flex-col w-4/5 justify-center text-white border border-0 rounded-b-2xl bg-[#947654] rounded-t-3xl drop-shadow-2xl">
      <div className="border border-[5px] border-black rounded-3xl relative inline-block drop-shadow-2xl">
        <Image
          src="/assets/images/homepage/background.png"
          alt="Restourant image"
          width={0}
          height={0}
          sizes="100vw"
          className="rounded-2xl overflow-hidden object-cover height-[600px] w-full"
        />
        <div className="absolute bottom-0 left-0 bg-opacity-50 bg-black rounded-2xl z-[100] w-[420px] h-[240px]">
          <div className="flex flex-col justify-center items-center w-full h-full text-[32px] leading-[42px] font-medium">
            <span>Bibliotekа resto•Bar</span>
            <span>Lviv • 150 ₴ • Italic</span>
          </div>
        </div>
        <div
          className="absolute rounded-full bg-[#5D462D] w-[130px] h-[130px] z-[101]"
          style={{
            bottom: -60,
            left: 35,
          }}
        >
          <div className="w-full h-full flex justify-center items-center">
            <Image
              src={arrowIcon}
              alt="forward icon"
              style={{ transform: "rotate(3.142rad)" }}
            />
          </div>
        </div>
        <div
          className="absolute rounded-full bg-[#CF914E] w-[100px] h-[100px] z-[101]"
          style={{
            bottom: -50,
            left: 200,
          }}
        >
          <div className="w-full h-full flex justify-center items-center">
            <Image src={editIcon} alt="add review icon" />
          </div>
        </div>
        <div
          className="absolute rounded-full bg-[#5D462D] w-[130px] h-[130px] z-[101]"
          style={{
            bottom: -60,
            right: 35,
          }}
        >
          <div className="w-full h-full flex justify-center items-center">
            <Image src={arrowIcon} alt="forward icon" />
          </div>
        </div>
        <div
          className="absolute rounded-full bg-[#A10005] w-[100px] h-[100px] z-[101]"
          style={{
            bottom: -50,
            right: 200,
          }}
        >
          <div className="w-full h-full flex justify-center items-center">
            <Image src={heartIcon} alt="heart icon" />
          </div>
        </div>
        <div
          className="absolute rounded-full bg-[rgba(0,0,0,0.7)] w-[100px] h-[100px] z-[101]"
          style={{
            top: "40%",
            right: 10,
            display: currentPhotoIndex === countOfPhoto - 1 ? "none" : "block",
          }}
          onClick={() => {
            const newIndex = currentPhotoIndex + 1;

            if (newIndex < countOfPhoto) {
              setCurrentPhotoIndex(newIndex);
            }
          }}
        >
          <div className="flex justify-center items-center w-full h-full">
            <Image src={imageArrowIcon} alt="arrow icon" />
          </div>
        </div>
        <div
          className="absolute rounded-full bg-[rgba(0,0,0,0.7)] w-[100px] h-[100px] z-[101]"
          style={{
            top: "40%",
            left: 10,
            display: currentPhotoIndex === 0 ? "none" : "block",
          }}
          onClick={() => {
            const newIndex = currentPhotoIndex - 1;

            if (newIndex >= 0) {
              setCurrentPhotoIndex(newIndex);
            }
          }}
        >
          <div
            className="flex justify-center items-center w-full h-full"
            style={{
              transform: "rotate(3.142rad)",
            }}
          >
            <Image src={imageArrowIcon} alt="arrow icon" />
          </div>
        </div>
        <div
          className="absolute z-[101]"
          style={{
            left: "50%",
            bottom: 20,
          }}
        >
          <div className="flex flex-row gap-3">
            {[0, 0, 0].map((_, index) => {
              return (
                <div
                  key={index}
                  className="rounded-full w-[14px] h-[14px]"
                  style={{
                    backgroundColor:
                      index === currentPhotoIndex ? "#FFF" : "#000",
                    opacity: index === currentPhotoIndex ? "100%" : "50%",
                  }}
                ></div>
              );
            })}
          </div>
        </div>
      </div>

      <div id="card_content" className="pt-20 pl-8 pr-8">
        <h1 className="text-5xl ml-8">Restaurant title</h1>
        <div className="flex flex-row mt-6 text-[36px] leading-[48px] font-semibold">
          <div className="inline-block w-1/2">
            <Stat icon="point" content="Lviv, st. Krakivska, 7" styles="mb-5" />
            <Stat icon="clock" content="10:00 — 22:00" styles="mb-5" />
            <Stat icon="coin" content="150-360 ₴" />
          </div>
          <div className="inline-block w-1/2">
            <Stat icon="cutlery" content="Italic food" styles="mb-5" />
            <Stat icon="telephone" content="0963406073" styles="mb-5" />
            <Stat icon="menu" content="Menu" />
          </div>
        </div>
        <div className="mt-6 text-[25px] font-semibold leading-[34px]">
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi eget
          faucibus tortor. Vivamus blandit eros in enim mollis, vel lobortis
          neque eleifend. Sed a consectetur tellus, ut sodales nibh. Lorem ipsum
          dolor sit amet, consectetur adipiscing elit. Nullam ut nulla urna.
          Aliquam dolor nisl, convallis sit amet diam ut, tempor euismod massa.
          Etiam commodo placerat libero, ut placerat elit sagittis vel. Aenean
          dignissim suscipit metus nec ornare. Phasellus sed risus quis metus
          vulputate mollis. Maecenas et justo at augue semper sagittis nec quis
          purus. Aenean auctor eros neque, vel mollis tortor lobortis vitae.
        </div>
      </div>
      <div className="pt-6 pl-8 pr-8 pb-10">
        <h1 className="text-5xl ml-8 mb-4">Client's Review</h1>
        <hr className="pb-7" />
        <div className="flex   gap-8">
          <div className="bg-[#5D462D] rounded-full py-6 px-5 shrink-0 h-fit">
            <img src={`${iconUrl}/cake.svg`} alt="cake" />
          </div>
          <div className="flex flex-col gap-3">
            <span className="text-4xl font-medium">Sweet Cake</span>
            <img className="w-fit" src={`${iconUrl}/hearts.svg`} alt="rating" />
            <span className="text-2xl">
              Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi
              eget faucibus tortor. Vivamus blandit eros in enim mollis, vel
              lobortis neque eleifend. Sed a consectetur tellus, ut sodales
              nibh. Lorem ipsum dolor sit amet, consectetur adipiscing elit.
              Nullam ut nulla urna. Aliquam dolor nisl, convallis sit amet diam
              ut, tempor euismod massa. Etiam commodo placerat libero, ut
              placerat elit sagittis vel.
            </span>
          </div>
        </div>
      </div>
    </div>
  );
}
