const UserProfile = () => {
  return (
    <div className="w-full">
      <div className="bg-[#9f784e] pl-20 pr-44 pt-16 flex flex-col w-full">
        <h1 className="mb-5">Profile</h1>
        <form className="flex flex-col gap-6 items-end">
          <div className="flex flex-col gap-3 w-full">
            <label className="text-3xl">First Name and Last Name</label>
            <input className="h-14 rounded-[20px]" />
          </div>
          <div className="flex flex-col gap-3 w-full">
            <label className="text-3xl">Nickname</label>
            <input className="h-14 rounded-[20px]" />
          </div>
          <div className="flex flex-col gap-3 w-full">
            <label className="text-3xl">Email</label>
            <input className="h-14 rounded-[20px]" type="email" />
          </div>
          <div className="flex flex-col gap-3 mb-5 w-full">
            <label className="text-3xl">Phone Number</label>
            <input className="h-14 rounded-[20px]" />
          </div>
          <div className="flex mb-4">
            <button className="px-9 text-2xl py-3 mr-[140px] w-fit font-bold rounded-3xl bg-[#695858]">
              Upload photo
            </button>
            <button className="px-9 text-2xl py-3 w-fit font-bold rounded-3xl bg-[#565656]">
              Show photo
            </button>
          </div>
          <button className="w-64 h-14 bg-[#F0BB81] rounded-[20px] text-[#5D462D] text-[2rem] font-bold translate-x-[40%] mb-5">
            Change info
          </button>
        </form>
      </div>
    </div>
  );
};

export default UserProfile;
