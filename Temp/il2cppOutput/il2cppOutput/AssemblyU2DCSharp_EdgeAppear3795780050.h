#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t4012695102;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// EdgeAppear
struct  EdgeAppear_t3795780050  : public MonoBehaviour_t3012272455
{
public:
	// System.Single EdgeAppear::last_position
	float ___last_position_2;
	// UnityEngine.GameObject EdgeAppear::Edge1
	GameObject_t4012695102 * ___Edge1_3;
	// UnityEngine.GameObject EdgeAppear::Edge2
	GameObject_t4012695102 * ___Edge2_4;
	// UnityEngine.GameObject EdgeAppear::Edge3
	GameObject_t4012695102 * ___Edge3_5;
	// UnityEngine.GameObject EdgeAppear::Edge4
	GameObject_t4012695102 * ___Edge4_6;
	// System.Int32 EdgeAppear::iUp
	int32_t ___iUp_7;
	// System.Single EdgeAppear::camerasize
	float ___camerasize_8;

public:
	inline static int32_t get_offset_of_last_position_2() { return static_cast<int32_t>(offsetof(EdgeAppear_t3795780050, ___last_position_2)); }
	inline float get_last_position_2() const { return ___last_position_2; }
	inline float* get_address_of_last_position_2() { return &___last_position_2; }
	inline void set_last_position_2(float value)
	{
		___last_position_2 = value;
	}

	inline static int32_t get_offset_of_Edge1_3() { return static_cast<int32_t>(offsetof(EdgeAppear_t3795780050, ___Edge1_3)); }
	inline GameObject_t4012695102 * get_Edge1_3() const { return ___Edge1_3; }
	inline GameObject_t4012695102 ** get_address_of_Edge1_3() { return &___Edge1_3; }
	inline void set_Edge1_3(GameObject_t4012695102 * value)
	{
		___Edge1_3 = value;
		Il2CppCodeGenWriteBarrier(&___Edge1_3, value);
	}

	inline static int32_t get_offset_of_Edge2_4() { return static_cast<int32_t>(offsetof(EdgeAppear_t3795780050, ___Edge2_4)); }
	inline GameObject_t4012695102 * get_Edge2_4() const { return ___Edge2_4; }
	inline GameObject_t4012695102 ** get_address_of_Edge2_4() { return &___Edge2_4; }
	inline void set_Edge2_4(GameObject_t4012695102 * value)
	{
		___Edge2_4 = value;
		Il2CppCodeGenWriteBarrier(&___Edge2_4, value);
	}

	inline static int32_t get_offset_of_Edge3_5() { return static_cast<int32_t>(offsetof(EdgeAppear_t3795780050, ___Edge3_5)); }
	inline GameObject_t4012695102 * get_Edge3_5() const { return ___Edge3_5; }
	inline GameObject_t4012695102 ** get_address_of_Edge3_5() { return &___Edge3_5; }
	inline void set_Edge3_5(GameObject_t4012695102 * value)
	{
		___Edge3_5 = value;
		Il2CppCodeGenWriteBarrier(&___Edge3_5, value);
	}

	inline static int32_t get_offset_of_Edge4_6() { return static_cast<int32_t>(offsetof(EdgeAppear_t3795780050, ___Edge4_6)); }
	inline GameObject_t4012695102 * get_Edge4_6() const { return ___Edge4_6; }
	inline GameObject_t4012695102 ** get_address_of_Edge4_6() { return &___Edge4_6; }
	inline void set_Edge4_6(GameObject_t4012695102 * value)
	{
		___Edge4_6 = value;
		Il2CppCodeGenWriteBarrier(&___Edge4_6, value);
	}

	inline static int32_t get_offset_of_iUp_7() { return static_cast<int32_t>(offsetof(EdgeAppear_t3795780050, ___iUp_7)); }
	inline int32_t get_iUp_7() const { return ___iUp_7; }
	inline int32_t* get_address_of_iUp_7() { return &___iUp_7; }
	inline void set_iUp_7(int32_t value)
	{
		___iUp_7 = value;
	}

	inline static int32_t get_offset_of_camerasize_8() { return static_cast<int32_t>(offsetof(EdgeAppear_t3795780050, ___camerasize_8)); }
	inline float get_camerasize_8() const { return ___camerasize_8; }
	inline float* get_address_of_camerasize_8() { return &___camerasize_8; }
	inline void set_camerasize_8(float value)
	{
		___camerasize_8 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
